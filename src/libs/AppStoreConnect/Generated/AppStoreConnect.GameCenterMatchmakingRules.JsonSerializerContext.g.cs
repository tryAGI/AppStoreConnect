
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ResourceLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagedDocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem134), TypeInfoPropertyName = "IncludedItem1342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTeam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem135), TypeInfoPropertyName = "IncludedItem1352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType), TypeInfoPropertyName = "GameCenterMatchmakingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType), TypeInfoPropertyName = "GameCenterMatchmakingRuleAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataType), TypeInfoPropertyName = "GameCenterMatchmakingRuleCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributesType), TypeInfoPropertyName = "GameCenterMatchmakingRuleCreateRequestDataAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType), TypeInfoPropertyName = "GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequestDataType), TypeInfoPropertyName = "GameCenterMatchmakingRuleUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDataPointValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResultLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueueLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity), TypeInfoPropertyName = "GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPointValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueueLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity), TypeInfoPropertyName = "GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPointValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueueLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularity), TypeInfoPropertyName = "GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>), TypeInfoPropertyName = "OneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourcePointer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourceParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>), TypeInfoPropertyName = "OneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociatedMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformationPaging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem), TypeInfoPropertyName = "GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem134?), TypeInfoPropertyName = "NullableIncludedItem1342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem135?), TypeInfoPropertyName = "NullableIncludedItem1352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributesType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleCreateRequestDataAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem>))]
    internal sealed partial class GameCenterMatchmakingRulesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterMatchmakingRulesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterMatchmakingRulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem134JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.IncludedItem135JsonConverter());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<string, global::AppStoreConnect.ErrorLinksAssociated>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleCreateRequestDataAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleCreateRequestDataAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingNumberRuleResultsGetMetricsSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

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
                    0 => new GameCenterMatchmakingRulesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}