
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterLeaderboardLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_458A7FC9C78489F9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_31ED136B7E3A9790.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_677BDB3FE41005F2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6763A1E8D5752320.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DAEFBC211166F42D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9CB7E15FE6952248.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_091F5FAE6720CE77.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_746EE9F01F9A2F57.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_64CA6384D50534A7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_930C7364B4E3576C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA5FB1746093E051.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA6E69B53E39A7D1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_01435C8CAEA1E974.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F8202EFF2BCE74BF.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterLeaderboardLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterLeaderboardLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterLeaderboardLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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