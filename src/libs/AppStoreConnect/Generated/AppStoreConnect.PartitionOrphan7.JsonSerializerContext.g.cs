
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan7SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1026137C591D6189.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_10B4378C43C78566.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_82418C090D288D4B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18AE1B7AA2F0E7B0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BCFC11AEA32CE053.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2F522C1667CD82ED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_072C147B50226172.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18FAAF5D5DBD9C90.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFABAAF3EAB147FE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_41F2FC0F63C17634.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B841E22BFCB60463.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ACF97CD8F48F609D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7EB4FB1F90B9F584.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5DC3FC1B8E8A4C93.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8406FE223F13FCC8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DBC5FA536E7C3C6C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D5BFA73CD2B45E27.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E85DC828B3FD463F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C138161A15C0107C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_935D17FFDA3D3346.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CE32E446821D8784.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AD27BAB2357E4986.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3BADFD830D544D51.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7D97A0338E9717B4.MetadataScope,                    static () => global::AppStoreConnect.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan7SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan7SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan7SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataType), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityCreateRequestDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataType?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityCreateRequestDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataRelationshipsSubscriptionDataType), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityCreateRequestDataRelationshipsSubscriptionDataTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataRelationshipsSubscriptionDataType?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityCreateRequestDataRelationshipsSubscriptionDataTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemType), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemTypeJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemType?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitieJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitieNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilitiesGetInstanceFieldsTerritorie), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilitiesGetInstanceFieldsTerritorieJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilitiesGetInstanceFieldsTerritorie?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilitiesGetInstanceFieldsTerritorieNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilitiesGetInstanceIncludeItem), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilitiesGetInstanceIncludeItemJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilitiesGetInstanceIncludeItem?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilitiesGetInstanceIncludeItemNullableJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorieJsonConverter());
            collector.AddEnum(typeof(global::AppStoreConnect.SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorie?), static () => new global::AppStoreConnect.JsonConverters.SubscriptionAvailabilitiesAvailableTerritoriesGetToManyRelatedFieldsTerritorieNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}