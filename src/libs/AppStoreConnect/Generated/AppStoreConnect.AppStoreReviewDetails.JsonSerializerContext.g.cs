
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppStoreReviewDetailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2A5FC11CC774BFE8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1429105012A71AF5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A61FDA0993F5892A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_52BD13713DF0F2B1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3285B152DFC458F4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_708944640646E867.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BB4481D9AA44C638.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C890E2A155BA35B0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A12B1104F95D6D04.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_311A98194F5C6C0F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E2E8E2033636CD77.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CACA9A07947087B0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BD18684692D3CB5F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C267AC2D19B186F6.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppStoreReviewDetailsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppStoreReviewDetailsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppStoreReviewDetailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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