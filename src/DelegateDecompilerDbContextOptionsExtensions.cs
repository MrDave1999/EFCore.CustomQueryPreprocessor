namespace Microsoft.EntityFrameworkCore;

public static class DelegateDecompilerDbContextOptionsExtensions
{
    public static DbContextOptionsBuilder AddDelegateDecompiler(this DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.AddQueryPreprocessor(new DelegateDecompilerQueryPreprocessor());
}