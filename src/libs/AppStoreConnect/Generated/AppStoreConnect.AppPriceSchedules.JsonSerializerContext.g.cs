
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataType), TypeInfoPropertyName = "AppPriceScheduleCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsApp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsAppData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsAppDataType), TypeInfoPropertyName = "AppPriceScheduleCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType), TypeInfoPropertyName = "AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPrices))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType), TypeInfoPropertyName = "AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.AppPriceV2InlineCreate, global::AppStoreConnect.TerritoryInlineCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.AppPriceV2InlineCreate, global::AppStoreConnect.TerritoryInlineCreate>), TypeInfoPropertyName = "OneOfAppPriceV2InlineCreateTerritoryInlineCreate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreateType), TypeInfoPropertyName = "AppPriceV2InlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreateAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointDataType), TypeInfoPropertyName = "AppPriceV2InlineCreateRelationshipsAppPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPricesV2Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "AppPricesV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType), TypeInfoPropertyName = "AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleBaseTerritoryLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleBaseTerritoryLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleBaseTerritoryLinkageResponseDataType), TypeInfoPropertyName = "AppPriceScheduleBaseTerritoryLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItemType), TypeInfoPropertyName = "AppPriceScheduleManualPricesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule), TypeInfoPropertyName = "AppPriceSchedulesGetInstanceFieldsAppPriceSchedule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp), TypeInfoPropertyName = "AppPriceSchedulesGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie), TypeInfoPropertyName = "AppPriceSchedulesGetInstanceFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice), TypeInfoPropertyName = "AppPriceSchedulesGetInstanceFieldsAppPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem), TypeInfoPropertyName = "AppPriceSchedulesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice), TypeInfoPropertyName = "AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint), TypeInfoPropertyName = "AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie), TypeInfoPropertyName = "AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie), TypeInfoPropertyName = "AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice), TypeInfoPropertyName = "AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint), TypeInfoPropertyName = "AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie), TypeInfoPropertyName = "AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataType?), TypeInfoPropertyName = "NullableAppPriceScheduleCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsAppDataType?), TypeInfoPropertyName = "NullableAppPriceScheduleCreateRequestDataRelationshipsAppDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType?), TypeInfoPropertyName = "NullableAppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType?), TypeInfoPropertyName = "NullableAppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.AppPriceV2InlineCreate, global::AppStoreConnect.TerritoryInlineCreate>?), TypeInfoPropertyName = "NullableOneOfAppPriceV2InlineCreateTerritoryInlineCreate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreateType?), TypeInfoPropertyName = "NullableAppPriceV2InlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointDataType?), TypeInfoPropertyName = "NullableAppPriceV2InlineCreateRelationshipsAppPricePointDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableAppPricesV2ResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppPriceScheduleAutomaticPricesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleBaseTerritoryLinkageResponseDataType?), TypeInfoPropertyName = "NullableAppPriceScheduleBaseTerritoryLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableAppPriceScheduleManualPricesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule?), TypeInfoPropertyName = "NullableAppPriceSchedulesGetInstanceFieldsAppPriceSchedule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableAppPriceSchedulesGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie?), TypeInfoPropertyName = "NullableAppPriceSchedulesGetInstanceFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice?), TypeInfoPropertyName = "NullableAppPriceSchedulesGetInstanceFieldsAppPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableAppPriceSchedulesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice?), TypeInfoPropertyName = "NullableAppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint?), TypeInfoPropertyName = "NullableAppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableAppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableAppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice?), TypeInfoPropertyName = "NullableAppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint?), TypeInfoPropertyName = "NullableAppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie?), TypeInfoPropertyName = "NullableAppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableAppPriceSchedulesManualPricesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.OneOf<global::AppStoreConnect.AppPriceV2InlineCreate, global::AppStoreConnect.TerritoryInlineCreate>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem>))]
    internal sealed partial class AppPriceSchedulesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPriceSchedulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppPriceSchedulesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppPriceSchedulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.AppPriceV2InlineCreate, global::AppStoreConnect.TerritoryInlineCreate>());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsAppDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsAppDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2InlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2InlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleBaseTerritoryLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleBaseTerritoryLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsAppDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleCreateRequestDataRelationshipsAppDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsAppDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleCreateRequestDataRelationshipsAppDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleCreateRequestDataRelationshipsBaseTerritoryDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleCreateRequestDataRelationshipsManualPricesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2InlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2InlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2InlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2InlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2InlineCreateRelationshipsAppPricePointDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceV2InlineCreateRelationshipsAppPricePointDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceV2InlineCreateRelationshipsAppPricePointDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricesV2ResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPricesV2ResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleAutomaticPricesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleAutomaticPricesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleAutomaticPricesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleBaseTerritoryLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleBaseTerritoryLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleBaseTerritoryLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleBaseTerritoryLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleManualPricesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceScheduleManualPricesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceScheduleManualPricesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppPriceScheduleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppPriceScheduleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceFieldsAppPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsAppPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesAutomaticPricesGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesAutomaticPricesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesBaseTerritoryGetToOneRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsAppPricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppPriceSchedulesManualPricesGetToManyRelatedIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new AppPriceSchedulesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}