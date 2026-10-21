
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterChallengeVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26B7FE5CE04B4EA1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_32307A2E58551D99.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CE715D65DF2F5C82.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A15E2725E3393A0C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_72DF11701548D107.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6230E7FC40EC4448.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C012CE7DFF354F76.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0B029F5DFD4E8DFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7B2D6BCF802C0CD1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FFF59E289B805944.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3BE8ED06A7D4CCF9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_119C569628D0B2CA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_67B34B6CFB65FAE7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8D94F993FBEE212E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_958458FBBD4E3344.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A90557EE987D9623.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9DC359290126DF32.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_017F048CDD192246.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterChallengeVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterChallengeVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterChallengeVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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