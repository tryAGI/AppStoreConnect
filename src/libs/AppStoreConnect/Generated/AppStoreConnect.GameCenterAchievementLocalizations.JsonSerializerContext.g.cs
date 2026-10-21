
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterAchievementLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AABE396A6B48250F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F423C4D7967486D1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A24FC738E5F5F1C9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A3C54F7C72FC40A9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_65623C0946FBF24D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8E59A406559D1DC0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_882DCFE44C304EA8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5D1840E51F44654E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6193006BF22F0F38.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2EBEC66D3FBC8504.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C4A4BF0D795E3DEF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E2B76B727FE5288B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3AC30842499A8231.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1491EC4E2024C65B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterAchievementLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterAchievementLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterAchievementLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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