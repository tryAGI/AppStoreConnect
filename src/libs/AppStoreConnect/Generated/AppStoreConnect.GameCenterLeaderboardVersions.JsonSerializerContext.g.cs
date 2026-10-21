
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterLeaderboardVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_48554DD9898FD82A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BE6563BCBCD3C4A4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_201EC2E793438260.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BF4B239F60E3DA7F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D8F81EF443A52179.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F175FB37B5EB15E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C363B418471FC236.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DEBD2FE02EC606B4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B55534D6B6B2A28B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B9955E9E70B64AC5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDD611ABF6073C42.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18F137A30CB5FED6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C07AA137E954D117.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterLeaderboardVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterLeaderboardVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterLeaderboardVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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