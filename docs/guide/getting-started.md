# Environment Setup

## Prerequisites

-   Docker or Docker compatible (Rancher, etc)
-   .NET 9 SDK with Aspire\* (Aspire is not required but recommended)

## Option 1: .NET Aspire (Recommended)

The fastest way to get started is using .NET Aspire orchestration:

Make you have the aspire workload installed, you can install using the following command.

```bash
dotnet workload install aspire
```

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

## Option 2: Docker

For containerized deployment:

```bash
docker compose up --build
```

## Option 3: Manual Setup

For full control over the setup process:

### 1. Database Setup

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

### 2. Run Individual Services

```bash
# Terminal 1 - API service
dotnet run --project Billing/src/Billing.Api

# Terminal 2 - Background service
dotnet run --project Billing/src/Billing.BackOffice

# Terminal 3 - Orleans service
dotnet run --project Billing/src/Billing.BackOffice.Orleans
```

### 3. Verify Setup

-   **API Health**: http://localhost:8101/health
-   **OpenAPI UI**: http://localhost:8101/scalar
-   **gRPC**: Connect to localhost:8102
