
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterAchievementsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_71B77AEF90E82773.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D093BA90BB53202.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5C851A121F744949.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C3397C3AE7C60BB1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C88248F30298E024.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4DA459BA07D522B0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1C7DC7AD75C8E559.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_465116A8A499C197.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E45B791DBDDB01B3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CDEE3D973868548B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_83FFD566C55DF5AF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8AA1A8D4980DFA23.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3ACD62421BB2A78E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1C007010576E06F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4D6C713D7B486743.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3FB5416C9AC16DA8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E3A9DE9EB337F694.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BAD2CA903CE226A4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2D1E669F444E5666.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_763C70C1A75F7B44.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterAchievementsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterAchievementsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterAchievementsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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