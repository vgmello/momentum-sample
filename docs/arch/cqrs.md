---
title: CQRS Implementation Pattern
---

# CQRS Implementation Pattern

This document outlines the Command Query Responsibility Segregation (CQRS) pattern implementation used in the billing application. The design mirrors real-world department operations, making it intuitive for junior engineers and non-technical product people to understand.

## Philosophy

The CQRS implementation follows these core principles:

-   **Real-world department metaphor**: Each folder represents a sub-department with its main activities
-   **Minimal ceremony**: Avoiding unnecessary abstractions and complex patterns
-   **Infrastructure as utilities**: Database, messaging, and other infrastructure are treated like office utilities
-   **Digital paper records**: Immutable data structures that can't change themselves
-   **Front office/Back office separation**: Public APIs for front office, async handlers for back office
-   **Developer-friendly**: Simple patterns that are easy to understand and maintain
-   **LLM-friendly**: Familiar real-world patterns that modern AI can easily comprehend

## Domain Structure

Each domain (like Cashiers, Invoices, Bills) follows this consistent structure:

```
src/Billing/Cashiers/
├── Commands/           # Write operations (what the department does)
├── Queries/            # Read operations (what the department knows)
├── Contracts/          # Public interfaces and models
│   ├── Models/         # Data structures
│   └── IntegrationEvents/ # Inter-department notifications
└── Data/
    └── Entities/       # Database representations
```

## Command Pattern

Commands represent work orders sent to departments. They follow a simple, consistent pattern.

### Command Structure

<<< @/../src/Billing/Cashiers/Commands/CreateCashier.cs{10-10}

### Command Validation

<<< @/../src/Billing/Cashiers/Commands/CreateCashier.cs{12-20}

### Command Handler

<<< @/../src/Billing/Cashiers/Commands/CreateCashier.cs{22-53}

### Database Command

<<< @/../src/Billing/Cashiers/Commands/CreateCashier.cs{24-25}

## Query Pattern

Queries represent information requests to departments. They focus on data retrieval without side effects.

### Query Structure

<<< @/../src/Billing/Cashiers/Queries/GetCashiers.cs{15-22}

### Query Handler

<<< @/../src/Billing/Cashiers/Queries/GetCashiers.cs{24-41}

### Database Query

<<< @/../src/Billing/Cashiers/Queries/GetCashiers.cs{43-48}

## Models and Contracts

### Domain Models

Models represent the "digital paper records" that departments work with:

<<< @/../src/Billing/Cashiers/Contracts/Models/Cashier.cs

### Data Entities

Database entities represent how records are stored:

<<< @/../src/Billing/Cashiers/Data/Entities/Cashier.cs

## Integration Events

Events are notifications sent between departments when important things happen.

### Event Structure

<<< @/../src/Billing/Cashiers/Contracts/IntegrationEvents/CashierCreated.cs

### Event Publishing

Events are returned from handlers but not directly published:

```csharp
// In handler - return event to be published
var createdEvent = new CashierCreated(command.TenantId, command.TenantId.GetHashCode(), result.Value);
return (result, createdEvent);
```

## API Integration

Controllers act as the front office reception desk, handling external requests.

### Controller Pattern

<<< @/../src/Billing.Api/Cashiers/CashiersController.cs{22-41}

### Result Handling

<<< @/../src/Billing.Api/Cashiers/CashiersController.cs{43-61}

## Database Interaction

Database operations use the `[DbCommand]` attribute for automatic code generation.

### Command Database Operations

```csharp
[DbCommand(sp: "billing.cashiers_create", nonQuery: true)]
public partial record InsertCashierCommand(
    Guid TenantId,
    Guid CashierId,
    string Name,
    string Email
) : ICommand<int>;
```

### Query Database Operations

```csharp
[DbCommand(fn: "SELECT * FROM billing.cashiers_get")]
public partial record GetCashiersDbQuery(
    int Limit,
    int Offset
) : IQuery<IEnumerable<CashierModel>>;
```

## Error Handling

The system uses the `Result<T>` pattern for explicit error handling without exceptions.

### Result Pattern

```csharp
// Success case
return Result.Success(cashier);

// Failure case
return Result.Failure<CashierModel>(new ValidationFailure("Name", "Name is required"));
```

### Validation Pattern

<<< @/../src/Billing/Cashiers/Commands/CreateCashier.cs{20-25}

## Testing Strategy

### Unit Testing

Tests focus on business logic without infrastructure concerns:

<<< @/../tests/Billing.Tests/Unit/Cashier/CreateCashierCommandHandlerTests.cs{24-44}

### Integration Testing

Integration tests verify complete request/response cycles:

<<< @/../tests/Billing.Tests/Integration/Cashiers/CreateCashierIntegrationTests.cs{21-42}

## Message Bus Integration

The message bus acts as the internal communication system between departments.

### Command Execution

```csharp
// Execute command
var result = await messaging.InvokeCommandAsync(command, cancellationToken);

// Execute query
var data = await messaging.InvokeQueryAsync(query, cancellationToken);
```

### Event Publishing

```csharp
// Events are automatically published when returned from handlers
return (result, new CashierCreated(tenantId, partitionKey, cashier));
```

## Back Office Processing

Back office operations handle asynchronous processing through event handlers.

### Event Handler Pattern

<<< @/../src/Billing.BackOffice/Messaging/BillingInboxHandler/CashierCreatedHandler.cs

## Best Practices

### 1. Command Design

-   **Single responsibility**: Each command does one thing
-   **Immutable**: Use record types for command definitions
-   **Validated**: Include validation rules close to the command
-   **Explicit results**: Return Result<T> instead of throwing exceptions

### 2. Query Design

-   **Read-only**: Queries should never modify data
-   **Paginated**: Always implement pagination for list queries
-   **Filtered**: Support filtering parameters where appropriate
-   **Cached**: Consider caching for frequently accessed data

### 3. Handler Design

-   **Static methods**: Use static handlers for better performance
-   **Dependency injection**: Inject dependencies through parameters
-   **Transactional**: Commands should be transactional
-   **Event generation**: Return events for important state changes

### 4. Model Design

-   **Immutable**: Use record types or readonly properties
-   **Validated**: Include validation attributes on models
-   **Mapped**: Separate API models from database entities
-   **Documented**: Include XML documentation for public APIs

### 5. Database Design

-   **Stored procedures**: Use stored procedures for complex operations
-   **Functions**: Use functions for read operations
-   **Parameters**: Use parameterized queries to prevent SQL injection
-   **Indexes**: Add appropriate indexes for query performance

## Anti-Patterns to Avoid

### ❌ Don't Do This

```csharp
// Complex inheritance hierarchies
public abstract class BaseCommandHandler<TCommand, TResult> { }

// Mutable commands
public class CreateCashierCommand
{
    public string Name { get; set; }  // Mutable!
}

// Throwing exceptions for business logic
public void Handle(CreateCashierCommand command)
{
    if (string.IsNullOrEmpty(command.Name))
        throw new ArgumentException("Name is required");  // Don't throw!
}
```

### ✅ Do This Instead

```csharp
// Simple static handlers
public static class CreateCashierCommandHandler
{
    public static async Task<(Result<CashierModel>, CashierCreated)> Handle(...)
}

// Immutable commands
public record CreateCashierCommand(
    string Name,
    string Email
) : ICommand<Result<CashierModel>>;

// Result pattern for business logic
public static async Task<Result<CashierModel>> Handle(...)
{
    if (string.IsNullOrEmpty(command.Name))
        return Result.Failure<CashierModel>(new ValidationFailure("Name", "Name is required"));
}
```

## Implementation Checklist

When implementing a new domain, follow this checklist:

### Commands

-   [ ] Create command record with validation
-   [ ] Implement static handler method
-   [ ] Add database command with `[DbCommand]` attribute
-   [ ] Return Result<T> and integration event
-   [ ] Add unit tests for handler logic

### Queries

-   [ ] Create query record with parameters
-   [ ] Implement static handler method
-   [ ] Add database query with `[DbCommand]` attribute
-   [ ] Return appropriate data types
-   [ ] Add unit tests for query logic

### Contracts

-   [ ] Define domain models in Contracts/Models
-   [ ] Create integration events in Contracts/IntegrationEvents
-   [ ] Add XML documentation for public APIs
-   [ ] Version contracts appropriately

### API

-   [ ] Create controller with thin wrappers
-   [ ] Use message bus for all operations
-   [ ] Implement proper HTTP status codes
-   [ ] Add API documentation

### Database

-   [ ] Create stored procedures for commands
-   [ ] Create functions for queries
-   [ ] Add appropriate indexes
-   [ ] Include database migration scripts

### Testing

-   [ ] Unit tests for all handlers
-   [ ] Integration tests for API endpoints
-   [ ] Test both success and failure scenarios
-   [ ] Include performance tests for critical paths

## Conclusion

This CQRS implementation prioritizes simplicity, maintainability, and developer productivity. By following real-world department metaphors and avoiding unnecessary abstractions, the codebase remains approachable for developers of all skill levels while maintaining the benefits of CQRS architecture.

The pattern ensures:

-   Clear separation between reads and writes
-   Scalable message-based communication
-   Robust error handling
-   Comprehensive testing support
-   Easy integration with external systems

Use this guide as a reference when implementing new domains or extending existing functionality in the billing system.
