http:
	dotnet run --project StardewCalculator

https:
	dotnet dev-certs https --trust
	dotnet run -lp https --project StardewCalculator

tests:
	dotnet test