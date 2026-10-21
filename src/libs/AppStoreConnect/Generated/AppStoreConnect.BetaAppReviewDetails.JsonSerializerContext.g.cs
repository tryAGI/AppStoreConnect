
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BetaAppReviewDetailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45DDF6A6D83E4FD3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B51A8BA13AC4B2CA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28BE5E6D2B8B1E68.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0B7E4C88929F4A92.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F80BC9F56C1A0159.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_34343BF500805B2E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8B0C7119D08F3A3C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_21447166DBE95FE2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BADFC18D85BE5265.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_40E81B88B3D1DC52.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6BA3266FDAF11E50.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1CE280E579112FAC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1748C0E5052F4590.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BetaAppReviewDetailsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BetaAppReviewDetailsSourceGenerationContext Default => DefaultHolder.Instance;
        private BetaAppReviewDetailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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