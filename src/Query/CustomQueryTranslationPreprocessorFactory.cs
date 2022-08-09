namespace Microsoft.EntityFrameworkCore.Query;

public class CustomQueryTranslationPreprocessorFactory : IQueryTranslationPreprocessorFactory
{
    public CustomQueryTranslationPreprocessorFactory(QueryTranslationPreprocessorDependencies dependencies, RelationalQueryTranslationPreprocessorDependencies relationalDependencies, IEnumerable<IQueryPreprocessor> processors)
    {
        Dependencies = dependencies;
        RelationalDependencies = relationalDependencies;
        Processors = processors;
    }
    protected QueryTranslationPreprocessorDependencies Dependencies { get; }
    protected RelationalQueryTranslationPreprocessorDependencies RelationalDependencies { get; }
    protected IEnumerable<IQueryPreprocessor> Processors { get; }
    public QueryTranslationPreprocessor Create(QueryCompilationContext queryCompilationContext)
        => new CustomQueryTranslationPreprocessor(Dependencies, RelationalDependencies, Processors, queryCompilationContext);
}
