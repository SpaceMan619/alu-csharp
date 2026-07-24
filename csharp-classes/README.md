# C# - Classes and Namespaces

This project introduces C# classes, objects, fields, constructors, properties,
methods, access modifiers, namespaces, encapsulation, and XML documentation.

## Tasks

| Task | Directory | Requirement |
| --- | --- | --- |
| 0. Braaainsss | `0-enemy` | Create an empty public `Zombie` class in the `Enemies` namespace. |
| 1. Healthy competition | `1-enemy` | Add a public `health` field and a constructor that initializes it to `0`. |
| 2. Health validation | `2-enemy` | Add `Zombie(int value)` and throw `ArgumentException` for negative health. |
| 3. Zombie health | `3-enemy` | Make `health` private and add public `GetHealth()`. |
| 4. Hello, my name is | `4-enemy` | Add private `name`, defaulting to `(No name)`, and a public `Name` property. |
| 5. Printing a zombie | `5-enemy` | Override `ToString()` with `Zombie Name: <name> / Total Health: <health>`. |

Every task has its own folder, source file, and `.csproj` file. The source
files intentionally contain no `Program.cs`; the course checker supplies its
own entry point or harness.

## Documentation

All public classes and members use XML documentation comments with `<summary>`
tags. Private fields use regular comments. Each project enables XML output with
`DocumentationFile`, so the generated documentation is available to tooling.

## Build and test

From this directory, build an individual task with:

```bash
dotnet build 0-enemy/0-enemy.csproj
```

The repository ignores generated `bin/` and `obj/` directories.
