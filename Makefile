dev:
	dotnet watch --project StardewCalculator

http:
	dotnet run --project StardewCalculator

https:
	dotnet dev-certs https --trust
	dotnet run -lp https --project StardewCalculator

build:
	docker build . -t stardew:latest

docker-run:
	docker run -p8080:8080 stardew

tests:
	dotnet test