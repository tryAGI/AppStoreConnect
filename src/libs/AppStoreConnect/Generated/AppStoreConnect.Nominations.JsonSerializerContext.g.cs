
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.Nomination))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationType), TypeInfoPropertyName = "NominationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationAttributesType), TypeInfoPropertyName = "NominationAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationAttributesState), TypeInfoPropertyName = "NominationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsRelatedApps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType), TypeInfoPropertyName = "NominationRelationshipsRelatedAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType), TypeInfoPropertyName = "NominationRelationshipsCreatedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType), TypeInfoPropertyName = "NominationRelationshipsLastModifiedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType), TypeInfoPropertyName = "NominationRelationshipsSubmittedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsInAppEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationRelationshipsInAppEventsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType), TypeInfoPropertyName = "NominationRelationshipsInAppEventsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType), TypeInfoPropertyName = "NominationRelationshipsSupportedTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.Nomination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "NominationsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType), TypeInfoPropertyName = "NominationResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataType), TypeInfoPropertyName = "NominationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType), TypeInfoPropertyName = "NominationCreateRequestDataAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedApps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType), TypeInfoPropertyName = "NominationCreateRequestDataRelationshipsRelatedAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType), TypeInfoPropertyName = "NominationCreateRequestDataRelationshipsInAppEventsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType), TypeInfoPropertyName = "NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataType), TypeInfoPropertyName = "NominationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType), TypeInfoPropertyName = "NominationUpdateRequestDataAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedApps))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType), TypeInfoPropertyName = "NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEvents))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType), TypeInfoPropertyName = "NominationUpdateRequestDataRelationshipsInAppEventsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritories))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType), TypeInfoPropertyName = "NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFilterTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem), TypeInfoPropertyName = "NominationsGetCollectionFilterTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem), TypeInfoPropertyName = "NominationsGetCollectionFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionSortItem), TypeInfoPropertyName = "NominationsGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsNomination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination), TypeInfoPropertyName = "NominationsGetCollectionFieldsNomination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp), TypeInfoPropertyName = "NominationsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor), TypeInfoPropertyName = "NominationsGetCollectionFieldsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent), TypeInfoPropertyName = "NominationsGetCollectionFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie), TypeInfoPropertyName = "NominationsGetCollectionFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem), TypeInfoPropertyName = "NominationsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination), TypeInfoPropertyName = "NominationsGetInstanceFieldsNomination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp), TypeInfoPropertyName = "NominationsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor), TypeInfoPropertyName = "NominationsGetInstanceFieldsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent), TypeInfoPropertyName = "NominationsGetInstanceFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie), TypeInfoPropertyName = "NominationsGetInstanceFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.NominationsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem), TypeInfoPropertyName = "NominationsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationType?), TypeInfoPropertyName = "NullableNominationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationAttributesType?), TypeInfoPropertyName = "NullableNominationAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationAttributesState?), TypeInfoPropertyName = "NullableNominationAttributesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType?), TypeInfoPropertyName = "NullableNominationRelationshipsRelatedAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType?), TypeInfoPropertyName = "NullableNominationRelationshipsCreatedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType?), TypeInfoPropertyName = "NullableNominationRelationshipsLastModifiedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType?), TypeInfoPropertyName = "NullableNominationRelationshipsSubmittedByActorDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType?), TypeInfoPropertyName = "NullableNominationRelationshipsInAppEventsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType?), TypeInfoPropertyName = "NullableNominationRelationshipsSupportedTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableNominationsResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType?), TypeInfoPropertyName = "NullableNominationResponseIncludedItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataType?), TypeInfoPropertyName = "NullableNominationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType?), TypeInfoPropertyName = "NullableNominationCreateRequestDataAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType?), TypeInfoPropertyName = "NullableNominationCreateRequestDataRelationshipsRelatedAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType?), TypeInfoPropertyName = "NullableNominationCreateRequestDataRelationshipsInAppEventsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType?), TypeInfoPropertyName = "NullableNominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataType?), TypeInfoPropertyName = "NullableNominationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType?), TypeInfoPropertyName = "NullableNominationUpdateRequestDataAttributesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType?), TypeInfoPropertyName = "NullableNominationUpdateRequestDataRelationshipsRelatedAppsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType?), TypeInfoPropertyName = "NullableNominationUpdateRequestDataRelationshipsInAppEventsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType?), TypeInfoPropertyName = "NullableNominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem?), TypeInfoPropertyName = "NullableNominationsGetCollectionFilterTypeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem?), TypeInfoPropertyName = "NullableNominationsGetCollectionFilterStateItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionSortItem?), TypeInfoPropertyName = "NullableNominationsGetCollectionSortItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination?), TypeInfoPropertyName = "NullableNominationsGetCollectionFieldsNomination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp?), TypeInfoPropertyName = "NullableNominationsGetCollectionFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor?), TypeInfoPropertyName = "NullableNominationsGetCollectionFieldsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent?), TypeInfoPropertyName = "NullableNominationsGetCollectionFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie?), TypeInfoPropertyName = "NullableNominationsGetCollectionFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem?), TypeInfoPropertyName = "NullableNominationsGetCollectionIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination?), TypeInfoPropertyName = "NullableNominationsGetInstanceFieldsNomination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp?), TypeInfoPropertyName = "NullableNominationsGetInstanceFieldsApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor?), TypeInfoPropertyName = "NullableNominationsGetInstanceFieldsActor2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent?), TypeInfoPropertyName = "NullableNominationsGetInstanceFieldsAppEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie?), TypeInfoPropertyName = "NullableNominationsGetInstanceFieldsTerritorie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableNominationsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationRelationshipsInAppEventsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.Nomination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFilterTypeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFilterStateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionSortItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsNomination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetCollectionIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsNomination>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsApp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsActor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.NominationsGetInstanceIncludeItem>))]
    internal sealed partial class NominationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NominationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static NominationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private NominationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.NominationType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationAttributesState)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationAttributesState?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.NominationType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationAttributesState))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationAttributesStateJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationAttributesState?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationAttributesStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsRelatedAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsRelatedAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsRelatedAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsCreatedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsCreatedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsCreatedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsLastModifiedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsLastModifiedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsLastModifiedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsSubmittedByActorDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSubmittedByActorDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsSubmittedByActorDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsInAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsInAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsInAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsSupportedTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationRelationshipsSupportedTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationResponseIncludedItemDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationResponseIncludedItemDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsRelatedAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsRelatedAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsInAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsInAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationCreateRequestDataRelationshipsSupportedTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataAttributesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataAttributesType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataAttributesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsRelatedAppsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsInAppEventsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEventsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsInAppEventsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationUpdateRequestDataRelationshipsSupportedTerritoriesDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFilterTypeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterTypeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFilterTypeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFilterStateItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFilterStateItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFilterStateItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionSortItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionSortItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionSortItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsNominationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsNomination?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsNominationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetCollectionIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetCollectionIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsNominationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsNomination?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsNominationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsActorJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsActor?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsActorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsAppEventJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsAppEvent?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsAppEventNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsTerritorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceFieldsTerritorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceFieldsTerritorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.NominationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.NominationsGetInstanceIncludeItemNullableJsonConverter();
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
                    0 => new NominationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}