
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BetaLicenseAgreementsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45DDF6A6D83E4FD3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_504942FF1ECE0FA9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0431E95A343B9F5F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_361712277A0D5C90.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_61AE7C3920C64AA7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_234D987B3BD59557.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D30D41625AB10261.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6C7463F7D57D8ECE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E940F8F76CF2C2CB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DDB7743928105C87.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0EE10D89806B0B04.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E07C6969715950A0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EB2AF26C528D9822.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BetaLicenseAgreementsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BetaLicenseAgreementsSourceGenerationContext Default => DefaultHolder.Instance;
        private BetaLicenseAgreementsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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