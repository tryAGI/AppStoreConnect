
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterLeaderboardSetVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_56F52DD6A4ABF101.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_37523E31A73068F8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7670542A503A15E1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B790DA8600F51E9C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B405CA03486C452.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E0F0C1BF8000D57.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_55522BA997BD3D41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E7DD1119EECEA8B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_40F311750804700C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_597695FD95036B88.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3DBD431AA89214FA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F0B07B1678DB4794.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_32CE39A76C7F37E2.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterLeaderboardSetVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterLeaderboardSetVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterLeaderboardSetVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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