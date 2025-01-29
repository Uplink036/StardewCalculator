.PHONY: help
help: ## Display this help
	@grep -E '^[a-zA-Z_-]+:.*?## .*$$' $(MAKEFILE_LIST) | sort | awk 'BEGIN {FS = ":.*?## "}; {printf "\033[36m%-30s\033[0m %s\n", $$1, $$2}'

.PHONY: dev
dev: ## Run the project in watch mode, any file changes will be reflected at runtime
	dotnet watch --project StardewCalculator

.PHONY: http
http: ## Run the project in http mode
	dotnet run --project StardewCalculator

.PHONY: https
https: ## Run the project in https mode
	dotnet dev-certs https --trust
	dotnet run -lp https --project StardewCalculator

.PHONY: build
build:
	docker build . -t stardew:latest

.PHONY: docker-run
docker-run:
	docker run -p8080:8080 stardew

.PHONY: tests
tests: ## Run all the tests
	dotnet test