namespace Microsoft.EntityFrameworkCore.Query;

public interface IQueryPreprocessor
{
    Expression Process(Expression query);
}
