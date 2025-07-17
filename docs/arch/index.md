# Billing Architecture

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
│   ├── docs/                        # DocFX documentation system
│   ├── infra/                       # Infrastructure and database
│   │   └── Billing.Database/        # Liquibase Database project
├── src/                         # Source code projects
│   │   ├── Billing/                 # Domain logic
│   │   ├── Billing.Api/             # REST/gRPC endpoints
│   │   ├── Billing.AppHost/         # .NET Aspire orchestration
│   │   ├── Billing.BackOffice/      # Background processing
│   │   ├── Billing.BackOffice.Orleans/  # Orleans stateful processing
│   │   └── Billing.Contracts/       # Integration events and models
│   └── test/                        # Testing projects
│       └── Billing.Tests/           # Unit, Integration, and Architecture tests
└── libs/                            # Shared libraries
    └── Operations/                  # Platform operations framework
        ├── docs/                    # Platform documentation
        ├── src/                     # Platform source code
        │   ├── Operations.Extensions/
        │   ├── Operations.Extensions.Abstractions/
        │   ├── Operations.Extensions.SourceGenerators/
        │   ├── Operations.ServiceDefaults/
        │   └── Operations.ServiceDefaults.Api/
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
