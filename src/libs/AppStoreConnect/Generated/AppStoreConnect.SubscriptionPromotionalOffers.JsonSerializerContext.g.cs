
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SubscriptionPromotionalOffersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FF37A1B63B1F676B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_59B3859384005DC6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85DF20C00882710C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6A13C8DA1DB386D7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91E452815CE669E8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EF5B9AB9F9865EF6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DD26A85CF985BD4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_17774859EC956468.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9BA66D44608E9A2E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3452C6356B99BEE9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E84E57470616BEF2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1215154327C2753B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C8F7DBAB4FF7DC50.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B332FBD53D7F8990.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FE8987D93F19E7BC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93342D6388776FF8.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SubscriptionPromotionalOffersSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SubscriptionPromotionalOffersSourceGenerationContext Default => DefaultHolder.Instance;
        private SubscriptionPromotionalOffersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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