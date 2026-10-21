
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C29AF99CF6553AB1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_576968E06D29E01D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1CEAD4D568CAF40F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA237E2BAD7DF464.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E0CED9540BC2F98B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8E8548608C8C6E97.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A30B9D9848F1D3AD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DCA3D51AE60CCD2E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_82A7326554FE890C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C06C68096C5E2534.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8F414E2AB30B33A1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B6951A930BCE7708.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4D9394CB29F86C09.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_20183A6A4A4823F5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CE6054F0838DF131.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_375E82F84237250B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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