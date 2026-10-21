
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterActivityLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27BFADAC59E781D5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C92FEC2323F62F3C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E0F080A0F346A8B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7AF45DD788C779FA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F3A4AD0463924CD0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9E7743F7F54D3F8C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D9BEB5C65D93D112.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA3CB9B9516DFBC6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E7E2B1DFACE37AD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3B73BD8D4279F6AD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BFE99EEF16260D95.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C9ACF00551AC3B63.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterActivityLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterActivityLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterActivityLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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