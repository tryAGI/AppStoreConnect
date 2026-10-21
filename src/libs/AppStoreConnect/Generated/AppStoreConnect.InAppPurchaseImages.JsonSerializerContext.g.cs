
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class InAppPurchaseImagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_37ED1EDA6FE97E86.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2AB8FB9E07CF5B5A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5924AEAB519B4354.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E1451A61980BFD4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_819D4F71A3890383.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_88195765D9387E87.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05A65D8A3619F92A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1F14796AE51272A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A908BEF967A131B4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CE1BF81D80F95200.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3ED8606C53CA59CD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3ACDBBF7637D11DD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_924EA39A28B86F31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E34B74CA46697534.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly InAppPurchaseImagesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static InAppPurchaseImagesSourceGenerationContext Default => DefaultHolder.Instance;
        private InAppPurchaseImagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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