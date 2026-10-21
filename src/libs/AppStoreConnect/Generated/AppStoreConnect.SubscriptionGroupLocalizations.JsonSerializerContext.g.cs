
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionGroupLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_98020F6F4D700BFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8C1F0D6E789A719C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E0980C4AD383C48.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_25049A01BEC8D4ED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_258D9FD11D11BFE5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BB97B274F4E9C7E5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A3FA5E6124C179C5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93986AD17BD7C375.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3C473ECAAFEE74DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FE3CFB9C6A80F389.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8C05BBF6C924A3E5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FFCB530380F45309.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EEF9A6EC62B08974.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_39737128AC100FB5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_55D4282750321A3F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D553AF566E55111.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionGroupLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionGroupLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionGroupLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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