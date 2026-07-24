# C# Test-Driven Development

Pierre's Bakery is a C# console application built with a test-first workflow.
Customers can order bread and pastries and receive the bakery's bundle deals.

## Pricing

- Bread costs $5 per loaf. Buy two loaves and get one free.
- Pastries cost $2 each. Buy three pastries and get one free.

## Projects

- `Bakery`: the console application and bakery models.
- `Bakery.Tests`: MSTest unit tests for the `Bread` and `Pastry` models.

## Run the application

From this directory:

```bash
dotnet run --project Bakery/Bakery.csproj
```

## Run the tests

From this directory:

```bash
dotnet test Bakery.Tests/Bakery.Tests.csproj
```
