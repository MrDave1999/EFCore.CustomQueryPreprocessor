namespace Microsoft.EntityFrameworkCore.Query;

public class DelegateDecompilerQueryPreprocessor : IQueryPreprocessor
{
    public Expression Process(Expression query) => DecompileExpressionVisitor.Decompile(query);
}
