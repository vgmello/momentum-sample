# syntax=docker/dockerfile:1-labs

# --- Build Stage for .NET and DocFX API generation ---
FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS dotnet

# Install gRPC tools
RUN apk add --no-cache grpc-plugins
ENV PROTOBUF_PROTOC=/usr/bin/protoc
ENV GRPC_PROTOC_PLUGIN=/usr/bin/grpc_csharp_plugin

# Install docfx global tool
RUN dotnet tool install -g docfx
ENV PATH="${PATH}:/root/.dotnet/tools"

WORKDIR /app

# Define exclusion patterns as environment variables for clarity
ENV EXCLUDE_TESTS='/\.Tests\.csproj/d'
ENV EXCLUDE_APPHOST='/\.AppHost\.csproj/d'

# Copy only project and solution files to restore dependencies
COPY --parents **/**/**/*.csproj .
COPY *.slnx Directory.Build.props Directory.Packages.props ./
# Remove Aspire and Tests (they are not needed for documentation)
RUN sed -i -e "$EXCLUDE_TESTS" -e "$EXCLUDE_APPHOST" ./*.slnx && dotnet restore --verbosity minimal

# Copy the rest of the source code for the build
COPY . .
RUN sed -i -e "$EXCLUDE_TESTS" -e "$EXCLUDE_APPHOST" ./*.slnx && dotnet build --no-restore

# Generate API reference documentation
WORKDIR /app/docs
RUN docfx docfx.json

# --- Build Stage for Node.js documentation site ---

FROM node:22-alpine AS docs
ENV PNPM_HOME="/pnpm"
ENV PATH="$PNPM_HOME:$PATH"
RUN corepack enable && corepack prepare pnpm@latest --activate && apk add --no-cache git

WORKDIR /docs/app/docs

# Install dependencies
COPY docs/package.json docs/pnpm-lock.yaml ./
RUN --mount=type=cache,id=pnpm,target=/pnpm/store pnpm install --frozen-lockfile

WORKDIR /docs

# Copy dotnet generated docs, the other docs will be mounted
COPY --from=dotnet /app/docs/reference ./reference

# # Run side (non-prod)
# CMD ["pnpm", "docs:dev", "--host"]
