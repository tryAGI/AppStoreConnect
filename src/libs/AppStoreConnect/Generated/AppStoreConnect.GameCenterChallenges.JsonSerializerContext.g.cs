
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterChallengesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_74DE1D8803B60CC9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8001151506F58F27.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9662090495869C9E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FCDFF5E820FC1486.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_09A5AC345CD5F268.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_21681214D779EA1F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0D63C77E8822E3A9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_67D10332B3DD0860.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1457BDAFD0FCECA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9780C100B35C1A96.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2EE97AF1EA9E130E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_24E5A4CEBDBBF4DD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E1859FBAE99525AC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5A859C75D1B9694C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D88F9DDF7A75699.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A20C459AC80EE3C0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B20D229A51E9A36F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_54CA8DDC2DCD15B8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AE4D06A9940CC427.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C600E21D7205DF99.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1F04F6EEE4D93E96.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_749027536A88B5E9.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterChallengesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterChallengesSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterChallengesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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