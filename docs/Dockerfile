FROM mcr.microsoft.com/dotnet/sdk:9.0-alpine

ENV PNPM_HOME="/pnpm"
ENV PATH="${PNPM_HOME}:${PATH}:/root/.dotnet/tools"

# Install node, pnpm, and docfx
RUN apk add --no-cache git nodejs && \
    wget -qO- https://get.pnpm.io/install.sh | ENV="$HOME/.shrc" SHELL="$(which sh)" sh - && \
    dotnet tool install -g docfx

# Install dependencies into the isolated /build directory.
# This directory will NOT be affected by the volume mount.
WORKDIR /app/docs
COPY docs/package.json docs/pnpm-lock.yaml ./
RUN --mount=type=cache,id=pnpm,target=/pnpm/store pnpm install --frozen-lockfile

CMD ["pnpm", "docs:dev", "--host"]
