
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_493658F3C6F7D8C7 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECFEF16776C89FB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_778730213D69B439.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7C55CA43BAA2FC04.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7F7DA7F071E1931C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B36A0483A26E5842.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4D09BC5233C35268.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E239563AD90D793C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA8758ACA3FACBCB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26CF9490AD7030E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_455F023C61709D2A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E67BA72574BC3F07.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5F87189D710B1714.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CF3F97356BB54163.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9AE4332779D9EE33.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_493658F3C6F7D8C7 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_493658F3C6F7D8C7 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_493658F3C6F7D8C7(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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