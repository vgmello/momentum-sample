# Billing Architecture

The Billing Service is part of a .NET 9 microservices system built using Domain-Driven Design principles. It provides a complete billing solution with modern web UI and comprehensive testing. It handles:

-   **Cashier Management**: Create and manage cashiers with multi-currency support
-   **Invoice Processing**: Handle invoice lifecycle with Orleans-based stateful processing
-   **Payment Integration**: Process payments and emit integration events
-   **Cross-Service Integration**: React to business events from other services like Accounting
-   **Modern Web UI**: SvelteKit-based responsive web application
-   **Comprehensive Testing**: Unit, integration, and end-to-end testing with real browsers

## Solution Structure

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

## Service Components

#### **Billing Services**

-   **Billing.Api** - Dual-protocol API (REST + gRPC) for cashier and invoice management
-   **Billing.BackOffice** - Event-driven background processing with Wolverine
-   **Billing.BackOffice.Orleans** - Stateful invoice processing using Orleans actors (3-replica cluster)
-   **Billing.Contracts** - Integration events and shared models for cross-service communication
-   **Billing** (Core) - Domain entities, commands, queries, and business logic with DDD patterns
-   **Billing.AppHost** - .NET Aspire orchestration with comprehensive service discovery

#### **Operations Libraries**

-   **Operations.ServiceDefaults** - Core infrastructure patterns (logging, health checks, messaging)
-   **Operations.ServiceDefaults.Api** - API-specific extensions (OpenAPI, gRPC, endpoint filters)
-   **Operations.Extensions** - Extension methods and utility implementations
-   **Operations.Extensions.Abstractions** - Core abstractions and interfaces
-   **Operations.Extensions.SourceGenerators** - Compile-time code generators for database operations

#### **Infrastructure & Documentation**

-   **Billing.Database** - Liquibase-based database management with multi-database pattern
-   **Billing/docs/** - This documentation

#### **Testing**

-   **Billing.Tests** - Comprehensive testing suite with unit, integration, and architecture tests

## Key Features

### Domain-Driven Design

-   **Entities**: Cashier and Invoice domain models with audit trails
-   **Commands**: Create operations with FluentValidation and source generation
-   **Queries**: Paginated retrieval with Dapper integration
-   **Integration Events**: Cross-service communication events

## Technology Stack

### **Backend Stack**

-   **.NET 9** with latest C# features and nullable reference types
-   **WolverineFx** for CQRS, event sourcing, and messaging
-   **Orleans** for stateful actor-based processing with Azure Storage clustering
-   **PostgreSQL 17** with Liquibase migrations and multi-database architecture
-   **gRPC** with Protocol Buffers for type-safe inter-service communication
-   **OpenTelemetry** for distributed tracing and observability
-   **Dapper** with source-generated command handlers for database operations
-   **FluentValidation** for command and query validation
-   **Serilog** for structured logging with correlation IDs

### **Testing & Quality**

-   **Testcontainers** for integration testing with real PostgreSQL containers
-   **NetArchTest** for architecture rule enforcement
-   **NSubstitute + Shouldly** for unit testing with fluent assertions
-   **xUnit** as the test framework with parallelization support

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
