
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterMatchmakingRulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5555B0D68A85810B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6AABDFDDC0FFDF8D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C75C47EB6FA62294.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5246C95241B3A74F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_74DE7D149022B98A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_210C23395E876E38.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6D62613F233896F5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C647A93B96994BA6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B36E08F21605A20F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DF9AB2A79CD580D7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_48B12FA7C6B13CB4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AE5EEB6D0BCFF2F8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_370273D61145181B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A37651B68E8DE966.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E71E9AFF34887175.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9F15E2CB946521DB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3A377DD9B40C4F87.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterMatchmakingRulesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterMatchmakingRulesSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterMatchmakingRulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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