namespace Microsoft.EntityFrameworkCore.Query;

public class CustomQueryTranslationPreprocessor : RelationalQueryTranslationPreprocessor
{
    public CustomQueryTranslationPreprocessor(QueryTranslationPreprocessorDependencies dependencies, RelationalQueryTranslationPreprocessorDependencies relationalDependencies, IEnumerable<IQueryPreprocessor> processors, QueryCompilationContext queryCompilationContext)
        : base(dependencies, relationalDependencies, queryCompilationContext) => Processors = processors;
    protected IEnumerable<IQueryPreprocessor> Processors { get; }
    public override Expression Process(Expression query)
    {
        foreach (var processor in Processors)
            query = processor.Process(query);
        return base.Process(query);
    }
}
