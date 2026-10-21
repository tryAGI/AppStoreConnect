
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_C25080753BB0F3FF : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4A6059A4DEA421DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_07E856BC746F1B26.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BF2D6D544A7FBA7E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA3455CD1845872C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_856A91EE5AEB2669.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BD56561E11E4583B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EB8A560F5BCCA91F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D4EBA42987A081E6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_837853212A8A77A2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2254688CDBBE1423.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91A9A8E9BDA00FE6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C60EAC1E875C63B3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9D74F7C1D99FCDF1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EC32B89E4148608F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_C25080753BB0F3FF Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_C25080753BB0F3FF Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_C25080753BB0F3FF(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}