# Billing Solution

The Billing Service manages cashiers, invoices, and payment processing within the broader platform. It provides both REST and gRPC APIs for managing billing operations and integrates with other services through event-driven messaging.

## TL;DR

This codebase is designed as an app template that mirrors real-world billing department operations\*, making it intuitive for junior engineers and non-technical product people to understand - each folder under Billing represents a sub-department with its main activities and processes, categorized as commands or queries. The design focuses on minimal ceremony code, avoiding almost all common tech abstractions, treats infrastructure like office utilities, uses digital representations of what would be "paper" records that can't change themselves but can be modified by external actors, Front office/desk operations are exposed as public sync APIs, and back office operations are supported by async event handlers.
The aim was for it to be extremely simple to use and very developer-friendly, however, as a positive, unexpected side effect, the simplicity and real-world mirroring approach also make the codebase naturally LLM-friendly, modern models can easily understand code that follows familiar real-world patterns.

## Code Structure and Design Philosophy

### Overview

This codebase is intentionally structured to mirror the real-world operations and organizational structure of a billing department.
Each part of the code corresponds or should correspond directly to a real-world role or operation, ensuring that the code remains 100% product-oriented and easy to understand.
The idea is that main operations/actions would be recognizable by a non-technical product person.

### Real-World Mirroring

For instance, if the billing department handles creating invoices, the code includes a clear and
direct set of actions to handle invoice creation.
Smaller tasks, or sub-actions, needed to complete a main action are also represented in a similar manner.
If a sub-action is only used within one main action, it remains nested inside that operation. If it needs to be reused by multiple operations,
it is extracted and made reusable, but still mirroring the real-world scenario.

### Avoiding Unnecessary Abstractions

This design philosophy avoids unnecessary abstractions. There are no additional layers like repositories or services unless they represent
something that exists in the real department. Infrastructure elements like logging or authorization are present as they support the system’s
functionality, same as water pipes and electricity support a billing department office. Even the database is viewed as a digital parallel to a
real-world archive or filing system.

### No "Domain" Objects

A key principle is the absence of smart objects. This means that an invoice, for example, is not an object that can change itself.
Instead, it is simply treated as a digital record, and all modifications are performed by "external" actors (something is changing the invoice,
the invoice does not change itself). This ensures that the code reflects digital representations of real-world entities and processes,
rather than trying to replicate objects with their own behaviors.

### Synchronous and Asynchronous Operations

The codebase also distinguishes between synchronous and asynchronous operations.
The API represents the front office of the billing department, handling synchronous operations where immediate responses are expected.
In contrast, the back office is represented by asynchronous operations that do not require immediate responses, allowing for efficient,
behind-the-scenes processing.

## What is the Billing Service?

The Billing Service is part of a .NET 9 microservices system built using Domain-Driven Design principles. It provides a complete billing solution with modern web UI and comprehensive testing. It handles:

-   **Cashier Management**: Create and manage cashiers with multi-currency support
-   **Invoice Processing**: Handle invoice lifecycle with Orleans-based stateful processing
-   **Payment Integration**: Process payments and emit integration events
-   **Cross-Service Integration**: React to business events from other services like Accounting
-   **Modern Web UI**: SvelteKit-based responsive web application
-   **Comprehensive Testing**: Unit, integration, and end-to-end testing with real browsers

## Service Architecture

The solution follows a microservices architecture with shared platform libraries:

```
.
├── docs/                            # DocFX documentation system
├── infra/                           # Infrastructure and database
│   └── Billing.Database/            # Liquibase Database project
├── src/                             # Source code projects
│   ├── Billing/                     # Domain logic
│   ├── Billing.Api/                 # REST/gRPC endpoints
│   ├── Billing.AppHost/             # .NET Aspire orchestration
│   ├── Billing.BackOffice/          # Background processing
│   ├── Billing.BackOffice.Orleans/  # Orleans stateful processing
│   └── Billing.Contracts/           # Integration events and models
├── tests/                           # Testing projects
│   └── Billing.Tests/               # Unit, Integration, and Architecture tests
└── libs/                            # Shared libraries
    └── Operations/                  # Operations libs
        ├── src/                     # Platform source code
        │   ├── Operations.Extensions.*
        │   ├── Operations.ServiceDefaults.*
        │   └── ...
        └── tests/                   # Platform tests
```

### Service Components

#### **Billing Services**

-   **Billing.Api** - Dual-protocol API (REST + gRPC) for cashier and invoice management
-   **Billing.BackOffice** - Event-driven background processing with Wolverine
-   **Billing.BackOffice.Orleans** - Stateful invoice processing using Orleans actors (3-replica cluster)
-   **Billing.Contracts** - Integration events and shared models for cross-service communication
-   **Billing** (Core) - Domain entities, commands, queries, and business logic with DDD patterns
-   **Billing.AppHost** - .NET Aspire orchestration with comprehensive service discovery

#### **Platform Operations Libraries**

-   **Operations.ServiceDefaults** - Core infrastructure patterns (logging, health checks, messaging)
-   **Operations.ServiceDefaults.Api** - API-specific extensions (OpenAPI, gRPC, endpoint filters)
-   **Operations.Extensions** - Extension methods and utility implementations
-   **Operations.Extensions.Abstractions** - Core abstractions and interfaces
-   **Operations.Extensions.SourceGenerators** - Compile-time code generators for database operations

#### **Infrastructure & Documentation**

-   **Billing.Database** - Liquibase-based database management with multi-database pattern
-   **Billing/docs/** - Service-specific DocFX documentation
-   **Operations/docs/** - Platform framework documentation with ADRs and code samples

#### **Testing**

-   **Billing.Tests** - Comprehensive testing suite with unit, integration, and architecture tests
-   **Operations.Extensions.Tests** - Platform library unit tests
-   **Operations.Extensions.SourceGenerators.Tests** - Source generator validation tests

## Key Features

### Domain-Driven Design

-   **Entities**: Cashier and Invoice domain models with audit trails
-   **Commands**: Create operations with FluentValidation and source generation
-   **Queries**: Paginated retrieval with Dapper integration
-   **Integration Events**: Cross-service communication events

### Technology Stack

#### **Backend Stack**

-   **.NET 9** with latest C# features and nullable reference types
-   **WolverineFx** for CQRS, event sourcing, and messaging
-   **Orleans** for stateful actor-based processing with Azure Storage clustering
-   **PostgreSQL 17** with Liquibase migrations and multi-database architecture
-   **gRPC** with Protocol Buffers for type-safe inter-service communication
-   **OpenTelemetry** for distributed tracing and observability
-   **Dapper** with source-generated command handlers for database operations
-   **FluentValidation** for command and query validation
-   **Serilog** for structured logging with correlation IDs

#### **Testing & Quality**

-   **Testcontainers** for integration testing with real PostgreSQL containers
-   **NetArchTest** for architecture rule enforcement
-   **NSubstitute + Shouldly** for unit testing with fluent assertions
-   **xUnit** as the test framework with parallelization support

### Source Generation

Custom source generators reduce boilerplate DB access code with attributes like:

```csharp
[DbCommand(sp: "billing.create_cashier", nonQuery: true)]
public partial record CreateCashierCommand(string Name, string? Email) : ICommand<Guid>;
```

## Quick Start

### Option 1: .NET Aspire (Recommended)

The fastest way to get started is using .NET Aspire orchestration:

```bash
# Run the entire Billing service stack
cd Billing/src/Billing.AppHost
dotnet run
```

This automatically:

-   ✅ Sets up PostgreSQL databases with Liquibase
-   ✅ Starts all services (API, BackOffice, Orleans)
-   ✅ Configures service discovery and dependencies
-   ✅ Provides observability dashboard
-   ✅ Uses persistent containers for consistent port allocation

#### Persistent Container Configuration

The Billing service uses `WithEndpointProxySupport(false)` for infrastructure services to maintain consistent port mappings across container restarts:

```csharp
var pgsql = builder
    .AddPostgres("billing-db", password: dbPassword, port: 54320)
    .WithEndpointProxySupport(false)  // Disables proxy, uses direct port binding
    .WithLifetime(ContainerLifetime.Persistent);
```

**Key Benefits:**

-   **Consistent Ports**: Infrastructure services (PostgreSQL, Kafka, PgAdmin) always use the same ports
-   **Persistent State**: Containers survive Aspire restarts, preserving database state
-   **Direct Access**: External tools can connect directly to known ports
-   **Development Efficiency**: No need to reconfigure connections after restarts

**Services with Persistent Port Binding:**

-   **PostgreSQL**: Always accessible at `localhost:54320`
-   **PgAdmin**: Always accessible at `localhost:54321`
-   **Kafka**: Always accessible at `localhost:59092`

**Access Points:**

-   **Aspire Dashboard**: http://localhost:18100
-   **Billing API**: http://localhost:8101/scalar
-   **Orleans Dashboard**: http://localhost:8104/dashboard
-   **Documentation**: http://localhost:8119

### Option 2: Manual Setup

For full control over the setup process:

#### 1. Database Setup

Run these commands from the `Billing/infra/Billing.Database/` directory:

```bash
cd Billing/infra/Billing.Database/

# Step 1: Setup databases (creates actual dbs)
liquibase update --defaults-file liquibase.setup.properties

# Step 2: Service bus schema
liquibase update --defaults-file liquibase.servicebus.properties

# Step 3: Application schema
liquibase update
```

#### 2. Run Individual Services

```bash
# Terminal 1 - API service
dotnet run --project Billing/src/Billing.Api

# Terminal 2 - Background service
dotnet run --project Billing/src/Billing.BackOffice

# Terminal 3 - Orleans service
dotnet run --project Billing/src/Billing.BackOffice.Orleans
```

#### 3. Verify Setup

-   **API Health**: http://localhost:8101/health
-   **OpenAPI UI**: http://localhost:8101/scalar
-   **gRPC**: Connect to localhost:8102

### Option 3: Docker Compose

### Option 3: Docker Compose

For containerized deployment:

```bash
docker compose up --build
```

## API Usage

### REST API Examples

```bash
# Create a cashier
curl -X POST http://localhost:8101/cashiers \
  -H "Content-Type: application/json" \
  -d '{"name": "John Doe", "email": "john@example.com"}'

# Get all cashiers (paginated)
curl http://localhost:8101/cashiers?pageNumber=1&pageSize=10

# Get specific cashier
curl http://localhost:8101/cashiers/{id}

# Get invoices
curl http://localhost:8101/invoices
```

### gRPC API

Use the Protocol Buffer definitions in `src/Billing.Api/Cashier/Protos/` for type-safe client generation.

```bash
# Connect with grpcurl
grpcurl -plaintext localhost:8102 list
grpcurl -plaintext -d '{"pageNumber": 1, "pageSize": 10}' localhost:8102 cashiers.CashiersService/GetCashiers
```

## Database Schema

### Tables

-   **cashiers**: Core cashier information with audit fields
-   **cashier_currencies**: Multi-currency support
-   **invoices**: Invoice management

### Stored Procedures

-   **billing.create_cashier**: Cashier creation with business rules

### Migration Management

Liquibase handles schema evolution with:

-   **Version Control**: All changes tracked in Git
-   **Rollback Support**: Safe rollback capabilities
-   **Environment Promotion**: Consistent schema across environments

## Development and Testing

### Running Tests

#### Backend Tests (C#)

```bash
# Run all backend tests
dotnet test

# Run specific test categories
dotnet test Billing/test/Billing.Tests --filter Category=Integration
dotnet test Billing/test/Billing.Tests --filter Category=Unit
dotnet test Billing/test/Billing.Tests --filter Category=Architecture

# Run platform library tests
dotnet test libs/Operations/tests/
```

### Test Categories

#### Billing Service Tests

1. **Unit Tests**: Fast, isolated component tests with NSubstitute mocks
2. **Integration Tests**: Service-level tests with real PostgreSQL and dependent services via Testcontainers
3. **Architecture Tests**: NetArchTest enforcement of DDD layering and dependencies

#### Platform Library Tests

-   **Unit Tests**: Testing core extension methods and utilities
-   **Source Generator Tests**: Validation of compile-time code generation
-   **Integration Tests**: Testing platform components with real dependencies

### Test Infrastructure

-   **Testcontainers**: Real PostgreSQL 17-alpine for integration tests
-   **Liquibase Migration**: Automated database setup in test containers

## Documentation

### Building Documentation

This service includes comprehensive documentation built with [DocFX](https://dotnet.github.io/docfx/).

#### Using Docker

Run from the **Billing** folder (not the docs folder):

```bash
# Build the image (from Billing folder)
docker build -f docs/Dockerfile -t billing-docfx .

# Run the container
docker run -d -p 8119:8080 --name billing-docs billing-docfx docs/docfx.json --serve -p 8119 // TODO: this is missing a volume mapping see aspire
```

#### Using Local DocFX

Run from the **Billing** folder:

```bash
# Install DocFX (if not already installed)
dotnet tool install -g docfx

# Serve documentation (from Billing folder)
docfx docs/docfx.json --serve -p 8119 -n "*"
```

**Working Directory**: All DocFX commands should be run from the **root** folder, not the `docs` folder. This allows DocFX to properly access the source code for API documentation generation.

**Correct**:

```bash
cd Billing/
docfx docs/docfx.json --serve -p 8119 -n "*"
```

**Incorrect**:

```bash
cd Billing/docs/
docfx docfx.json --serve -p 8119 -n "*"  # Won't find source code
```

#### Using .NET Aspire

The documentation service is automatically included when running the Billing AppHost:

```bash
cd src/Billing.AppHost
dotnet run
```

The documentation will be available in the Aspire dashboard with a direct link.

### Accessing the Documentation

Once running, the documentation is available at:

-   **Local**: http://localhost:8119

### Documentation Structure

```
docs/
├── content/              # Markdown documentation files
│   ├── architecture.md   # Detailed architectural patterns
│   ├── api-reference.md  # Complete REST and gRPC API docs
│   ├── database.md       # Database schema and migrations
│   ├── toc.yml           # Table of contents
│   └── ...
├── templates/            # DocFX theme
├── images/               # Documentation assets
├── docfx.json            # DocFX configuration
└── index.md              # Documentation homepage (Link to README.md)
```

### Important Notes

## Integration Events

The Billing service communicates with other services through integration events:

### Published Events

-   **CashierCreatedEvent**: Emitted when a new cashier is created
-   **CashierUpdatedEvent**: Emitted when cashier information changes
-   **InvoicePaidEvent**: Emitted when an invoice payment is processed

### Consumed Events

-   **BusinessDayEndedEvent**: Reacts to accounting business day operations

## Orleans Integration

The Billing.BackOffice.Orleans service provides stateful invoice processing:

### Features

-   **Invoice Grains**: Stateful actors for invoice lifecycle management
-   **3 Replicas**: High availability with Orleans clustering and Azure Storage
-   **Direct API**: HTTP endpoints for invoice operations
-   **Orleans Dashboard**: Real-time grain monitoring at `/dashboard`

### Invoice Operations

-   **POST** `/invoices/{id}/pay` - Process invoice payment
-   **GET** `/invoices/{id}` - Retrieve invoice state
-   **Dashboard**: http://localhost:8104/dashboard - Grain health and performance monitoring

## Monitoring and Observability

### Health Checks

-   **API Health**: `/health` endpoint with dependency checks
-   **Service Dependencies**: Database connectivity validation
-   **Orleans Health**: Grain health monitoring

### Logging

-   **Serilog**: Structured logging with correlation IDs
-   **OpenTelemetry**: Distributed tracing across services
-   **Integration**: XUnit sink for test output

### Metrics

-   **Custom Metrics**: Domain-specific business metrics
-   **Performance**: Database operation timing
-   **Orleans Metrics**: Grain activation and processing metrics

## Troubleshooting

### Common Issues

#### Database Connection Errors

```bash
# Check PostgreSQL is running
netstat -tulpn | grep 5432

# Verify database exists
psql -h localhost -U postgres -l
```

#### Port Conflicts

```bash
# Check if ports are in use
netstat -tulpn | grep 8101
netstat -tulpn | grep 8119
```

#### Container Issues

```bash
# Check container logs
docker logs billing-docs

# Check container status
docker ps -a
```

#### Test Failures

-   Ensure Docker is running for Testcontainers
-   Check PostgreSQL is available on localhost:5432
-   Verify Liquibase migrations are current

### Documentation Issues

#### Documentation not updating

-   Rebuild the Docker image after making changes
-   Clear browser cache
-   Check that markdown files are valid

#### API documentation missing

-   Ensure source code has XML documentation comments
-   Check that project references are correct in `docfx.json`
-   Verify build succeeds without errors

#### Theme not loading

-   Check that `docfx.json` references the correct template path
-   Verify theme files are not corrupted

## Contributing

### Adding New Features

1. Follow DDD patterns in the core domain
2. Add integration tests for new functionality
3. Update documentation in `docs/content/`
4. Ensure all tests pass

### Documentation Updates

1. Add new markdown files to `content/` directory
2. Update table of contents in `toc.yml`
3. Test changes locally with DocFX
4. Update this README if adding new capabilities

### Database Changes

1. Create new Liquibase changesets
2. Test migrations in local environment
3. Update database documentation
4. Ensure rollback scripts are available

## Additional Resources

-   **[Architecture Documentation](docs/content/architecture.md)** - Detailed design patterns
-   **[API Reference](docs/content/api-reference.md)** - Complete API documentation
-   **[Database Schema](docs/content/database.md)** - Database design and migrations
-   **[CLAUDE.md](../CLAUDE.md)** - AI assistant development guidance
