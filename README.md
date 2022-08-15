# EFCore.CustomQueryPreprocessor
[![Nuget-Badges](https://buildstats.info/nuget/EFCore.CustomQueryPreprocessor)](https://www.nuget.org/packages/EFCore.CustomQueryPreprocessor/)

I am not the creator of the code for this repository. The only thing I did was to wrap Ivan Stoev code in a class library for reuse in other projects.

All credits to Ivan Stoev.

Read Ivan Stoev original answer: https://stackoverflow.com/a/62138200

## Installation

Execute the following command in the terminal:
```bash
dotnet add package EFCore.CustomQueryPreprocessor
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
