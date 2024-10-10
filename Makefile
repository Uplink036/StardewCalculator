http:
	dotnet run

https:
	dotnet dev-certs https --trust
	dotnet run -lp https

test:
	dotnet test