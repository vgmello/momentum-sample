# syntax=docker/dockerfile:1-labs
FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine AS dotnet

RUN dotnet tool install -g docfx
ENV PATH="${PATH}:/root/.dotnet/tools"

WORKDIR /src

COPY --parents **/**/**/*.csproj .
# Copy global build configuration files first (changes rarely)
COPY *.slnx .
COPY Directory.Packages.props .
COPY Directory.Build.props .

# Restore packages - this layer is cached unless dependencies change
RUN dotnet restore --verbosity minimal

# Copy source code (this layer invalidates on any code change)
COPY . .

RUN dotnet build

WORKDIR /app/docs
RUN docfx docfx.json

FROM node:22-alpine AS docs
ENV PNPM_HOME="/pnpm"
ENV PATH="$PNPM_HOME:$PATH"
RUN corepack enable && corepack prepare pnpm@latest --activate
WORKDIR /app
COPY docs/package.json docs/pnpm-lock.yaml ./






ENTRYPOINT [ "docfx" ]
