
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterLeaderboardSetLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC255D0155256D4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A88E6F8B41035913.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18C667184DB3EEB0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D6782471B349CC7E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5DC2A76C3892D5BE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2F167495EB88C9BC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AEFD264B2AA4BCAF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DF9C01873800951C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AA02A9CDD0B292F9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_24B6452FDA6E1217.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_525454C4C9EFCB7F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F2731320813339D2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3929C01AB2E2979B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AD1B71270BE6D898.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterLeaderboardSetLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterLeaderboardSetLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterLeaderboardSetLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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