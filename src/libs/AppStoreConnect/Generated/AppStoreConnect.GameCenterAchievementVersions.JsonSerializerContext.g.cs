
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterAchievementVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D3E38128BBDD7348.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_097069E127B47CD4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_346102F9AA90D602.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_150794826397897C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E57A9D7D5CEB35F7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E016830BE192E6CC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F6CFF1C492328358.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1F731A2011BD75B5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FB5C5B5DA970F357.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D787F781BCB7374B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B98E8F30978BC001.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7880E551A17EE0B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3CBF253298576137.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterAchievementVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterAchievementVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterAchievementVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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