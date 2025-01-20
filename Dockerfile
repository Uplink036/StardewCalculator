FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /StardewCalculator
COPY StardewCalculator/StardewCalculator.csproj .
RUN dotnet restore StardewCalculator.csproj
COPY StardewCalculator/ .
RUN dotnet build StardewCalculator.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish StardewCalculator.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StardewCalculator.dll"]
