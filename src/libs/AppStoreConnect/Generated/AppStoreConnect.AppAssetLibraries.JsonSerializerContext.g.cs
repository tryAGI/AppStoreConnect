
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppAssetLibrariesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3246839AA53AF575.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_078772C1D98A8A73.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_73822D1F45D516BF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D4FBE559330B2ABE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B3D465AE2F4F85DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_40E45E1D2661D92B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_013F228872482336.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6D9E523446B0798F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_129BD9305A76B5C6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4AA267AD8F1FE3B1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_31FCE341A1CD8464.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C2C1672E6AFA993D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_37AF82CCD830EF19.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_352B442CE213870A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDAA73A5CF4722B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9839A25C328DA1DE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FCE047B4EE8CC591.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ACF2B1DAF4299515.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppAssetLibrariesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppAssetLibrariesSourceGenerationContext Default => DefaultHolder.Instance;
        private AppAssetLibrariesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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