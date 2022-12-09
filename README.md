# EFCore.CustomQueryPreprocessor
[![Nuget-Badges](https://buildstats.info/nuget/EFCore.CustomQueryPreprocessor)](https://www.nuget.org/packages/EFCore.CustomQueryPreprocessor/)

I am not the creator of the code for this repository. The only thing I did was to wrap Ivan Stoev code in a class library for reuse in other projects.

All credits to Ivan Stoev.

Read Ivan Stoev original answer: https://stackoverflow.com/a/62138200

## Installation

Run the following command in the terminal if your project is using EF Core 3.1/5.0:
```bash
dotnet add package EFCore.CustomQueryPreprocessor -v 1.0.0
```
In case your project uses EF Core 6.0/7.0, run the following:
```cs
dotnet add package EFCore.CustomQueryPreprocessor -v 2.0.0
```

## Usage

Call the following method in `DbContext.OnConfiguring`:
```cs
public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddDelegateDecompiler();
    }
}
```
And don't forget to add the `[Decompile]` decorator on the methods you want to decompile.
