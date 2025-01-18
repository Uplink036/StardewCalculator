# Runtime stage
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine
COPY . /app
WORKDIR /app
ENTRYPOINT ["dotnet", "run", "--project", "StardewCalculator"]