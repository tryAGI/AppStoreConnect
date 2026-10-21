
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppAssetLibraryPlacementsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_46D13D7C1D5008D9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2C133C05496FFD5C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_424CF783BB49F16C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_43EDD809D67C7BB1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_098E1F1D28945945.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4E92F7979BD245E3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_797B5A859E956A6B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_592E3DC796D339C6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BDCB5DBB64D3E4DE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A2AFB674691B0B95.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0D2DF29D42BB46E9.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppAssetLibraryPlacementsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppAssetLibraryPlacementsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppAssetLibraryPlacementsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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