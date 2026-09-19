
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.RelationshipLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType), TypeInfoPropertyName = "GameCenterMatchmakingQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType), TypeInfoPropertyName = "GameCenterMatchmakingQueueRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType), TypeInfoPropertyName = "GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataType), TypeInfoPropertyName = "GameCenterMatchmakingQueueCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataType), TypeInfoPropertyName = "GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType), TypeInfoPropertyName = "GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataType), TypeInfoPropertyName = "GameCenterMatchmakingQueueUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType), TypeInfoPropertyName = "GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType), TypeInfoPropertyName = "GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRules))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem134), TypeInfoPropertyName = "IncludedItem1342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTeam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem135), TypeInfoPropertyName = "IncludedItem1352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPointValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity), TypeInfoPropertyName = "GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPointValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData), TypeInfoPropertyName = "GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsGameCenterDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsGameCenterDetailLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity), TypeInfoPropertyName = "GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPointValues))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity), TypeInfoPropertyName = "GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue), TypeInfoPropertyName = "GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet), TypeInfoPropertyName = "GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionIncludeItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue), TypeInfoPropertyName = "GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet), TypeInfoPropertyName = "GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity), TypeInfoPropertyName = "GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity), TypeInfoPropertyName = "GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult), TypeInfoPropertyName = "GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity), TypeInfoPropertyName = "GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity), TypeInfoPropertyName = "GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult), TypeInfoPropertyName = "GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity), TypeInfoPropertyName = "GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem), TypeInfoPropertyName = "GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetRelationshipsRulesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem134?), TypeInfoPropertyName = "NullableIncludedItem1342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem135?), TypeInfoPropertyName = "NullableIncludedItem1352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem>))]
    internal sealed partial class GameCenterMatchmakingQueuesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueuesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterMatchmakingQueuesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterMatchmakingQueuesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRelationshipsRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRelationshipsRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSetDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueSizesV1MetricResponseDataItemGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultDataJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultDataNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueueJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueue?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingQueueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetCollectionFieldsGameCenterMatchmakingRuleSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueueJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueue?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingQueueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetInstanceFieldsGameCenterMatchmakingRuleSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingQueueSizesGetMetricsSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResultJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResult?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsFilterResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesExperimentMatchmakingRequestsGetMetricsSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingQueueSizesGetMetricsSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsGroupByItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResultJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResult?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsFilterResultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingRequestsGetMetricsSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularityJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularity?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsGranularityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueuesMatchmakingSessionsGetMetricsSortItemNullableJsonConverter();
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
                    0 => new GameCenterMatchmakingQueuesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}