
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppPreviewSetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E9C5511F0EB3842F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_091350810971AB24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E00C5DFAADF42DB2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_64DA5B0F48EB6B4B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6E49CFF8EFC9DAF6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7ADEF39F785D37F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BE9FBD8E176E722B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C108291FCD8D85FE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_22055F8A676BA8EE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EE6123956898FE27.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DD3B001E8F27D79.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_336D0CF372794E13.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E5446E858336C6EC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0BAE0C3EE0332DFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3F975A56543CAA4B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DCFE3191EEEE43CA.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppPreviewSetsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppPreviewSetsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppPreviewSetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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