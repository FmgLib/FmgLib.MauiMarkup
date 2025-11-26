## Creating a new FmgLib.MauiMarkup project from CLI

FmgLib provides a project template to start a new project with FmgLib.MauiMarkup.

**Install latest templates from NuGet:**
```bash
dotnet new install FmgLib.MauiMarkup.Template
```


**Create a new project:**

```bash
dotnet new fmglib-mauimarkup-app -o my-new-project
```

Optional parameters:
- `--netMajor 10|9` (default 10) to pick the .NET/MAUI version and matching package versions.
- `--includeContent true|false` (default false) to choose between a minimal home page or a richer sample experience.

The template now also drops a solution file alongside the project for an easier IDE start.
