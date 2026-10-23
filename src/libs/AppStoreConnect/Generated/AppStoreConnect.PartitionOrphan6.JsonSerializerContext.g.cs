
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan6SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A655B9A45C70E1EF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_29C47C1923937291.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_28F62A09F541DB75.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6D7F957104CF380D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_51B8A6CF92982D65.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3E845759A4FEFDF0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_113F9B6E3F9148FD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED80595214EAB429.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3B5C6D563D1751DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9610B9FC45CCE8B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E96CA7005ACA72E5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D240CA2195034B4C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0568518B6B6FDA4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_10F736F7FB640B70.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C7AC1B37493F2290.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1BBD374C911556FB.MetadataScope,                    static () => global::AppStoreConnect.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan6SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan6SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan6SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::AppStoreConnect.MarketplaceWebhookType), static () => new global::AppStoreConnect.JsonConverters.MarketplaceWebhookTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.MarketplaceWebhookType?), static () => new global::AppStoreConnect.JsonConverters.MarketplaceWebhookTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.MarketplaceWebhookCreateRequestDataType), static () => new global::AppStoreConnect.JsonConverters.MarketplaceWebhookCreateRequestDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.MarketplaceWebhookCreateRequestDataType?), static () => new global::AppStoreConnect.JsonConverters.MarketplaceWebhookCreateRequestDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.MarketplaceWebhookUpdateRequestDataType), static () => new global::AppStoreConnect.JsonConverters.MarketplaceWebhookUpdateRequestDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.MarketplaceWebhookUpdateRequestDataType?), static () => new global::AppStoreConnect.JsonConverters.MarketplaceWebhookUpdateRequestDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhook), static () => new global::AppStoreConnect.JsonConverters.MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhookJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhook?), static () => new global::AppStoreConnect.JsonConverters.MarketplaceWebhooksGetCollectionFieldsMarketplaceWebhookNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}