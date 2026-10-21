
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_3EC93F519678DF63 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA74FE41E89FE5E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DCEBF32C286C518.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7DC500AA45FA7F28.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_727771CE763C190A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8EE20859C540D15D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02D5D2419CFF6C72.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85BCCE439C0B2574.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5322620595795DCC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_15A6DD1558FB1D8F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_3EC93F519678DF63 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_3EC93F519678DF63 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_3EC93F519678DF63(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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