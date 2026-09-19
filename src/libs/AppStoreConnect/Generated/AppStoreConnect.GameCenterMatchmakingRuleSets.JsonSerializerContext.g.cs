
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem134>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem134), TypeInfoPropertyName = "IncludedItem1342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTeam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.IncludedItem135>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem135), TypeInfoPropertyName = "IncludedItem1352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequestDataType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType), TypeInfoPropertyName = "GameCenterMatchmakingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType), TypeInfoPropertyName = "GameCenterMatchmakingRuleAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRulesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType), TypeInfoPropertyName = "GameCenterMatchmakingTeamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTeamAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTeamsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam), TypeInfoPropertyName = "GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueRelationshipsRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingQueueRelationshipsExperimentRuleSetDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetRelationshipsRulesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem134?), TypeInfoPropertyName = "NullableIncludedItem1342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.IncludedItem135?), TypeInfoPropertyName = "NullableIncludedItem1352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequestDataType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingTeamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam?), TypeInfoPropertyName = "NullableGameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem134>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.IncludedItem135>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam>))]
    internal sealed partial class GameCenterMatchmakingRuleSetsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterMatchmakingRuleSetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterMatchmakingRuleSetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeamsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRulesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueuesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule?)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam)

                    || typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam?);
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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetUpdateRequestDataTypeNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTeamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingTeamType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingTeamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetMatchmakingQueuesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetRulesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetTeamsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeamJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeam?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingTeamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRule?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingRuleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueueJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueue?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionFieldsGameCenterMatchmakingQueueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeamJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeam?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingTeamNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRule?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingRuleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueueJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueue?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceFieldsGameCenterMatchmakingQueueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueueJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueue?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingQueueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSet?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedFieldsGameCenterMatchmakingRuleSetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsMatchmakingQueuesGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRuleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRule?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsRulesGetToManyRelatedFieldsGameCenterMatchmakingRuleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeamJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam?))
                {
                    return new global::AppStoreConnect.JsonConverters.GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeamNullableJsonConverter();
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
                    0 => new GameCenterMatchmakingRuleSetsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}