namespace Microsoft.EntityFrameworkCore;

public static partial class CustomDbContextOptionsExtensions
{
    public static DbContextOptionsBuilder AddQueryPreprocessor(this DbContextOptionsBuilder optionsBuilder, IQueryPreprocessor processor)
    {
        var option = optionsBuilder.Options.FindExtension<CustomOptionsExtension>()?.Clone() ?? new CustomOptionsExtension();
        if (option.Processors.Count == 0)
            optionsBuilder.ReplaceService<IQueryTranslationPreprocessorFactory, CustomQueryTranslationPreprocessorFactory>();
        else
            option.Processors.Remove(processor);
        option.Processors.Add(processor);
        ((IDbContextOptionsBuilderInfrastructure)optionsBuilder).AddOrUpdateExtension(option);
        return optionsBuilder;
    }
}
