namespace Microsoft.EntityFrameworkCore.Infrastructure;

public class CustomOptionsExtension : IDbContextOptionsExtension
{
    public CustomOptionsExtension() { }
    private CustomOptionsExtension(CustomOptionsExtension copyFrom) => Processors = copyFrom.Processors.ToList();
    public CustomOptionsExtension Clone() => new CustomOptionsExtension(this);
    public List<IQueryPreprocessor> Processors { get; } = new List<IQueryPreprocessor>();
    ExtensionInfo info;
    public DbContextOptionsExtensionInfo Info => info ?? (info = new ExtensionInfo(this));
    public void Validate(IDbContextOptions options) { }
    public void ApplyServices(IServiceCollection services)
        => services.AddSingleton<IEnumerable<IQueryPreprocessor>>(Processors);
    private sealed class ExtensionInfo : DbContextOptionsExtensionInfo
    {
        public ExtensionInfo(CustomOptionsExtension extension) : base(extension) { }
        new private CustomOptionsExtension Extension => (CustomOptionsExtension)base.Extension;
        public override bool IsDatabaseProvider => false;
        public override string LogFragment => string.Empty;
        public override void PopulateDebugInfo(IDictionary<string, string> debugInfo) { }
        public override long GetServiceProviderHashCode() => Extension.Processors.Count;
    }
}