
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalization,
        /// <summary>
        ///
        /// </summary>
        AppEventLocalization,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalization,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalization,
        /// <summary>
        ///
        /// </summary>
        CreatedDate,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        LastModifiedDate,
        /// <summary>
        ///
        /// </summary>
        MediaType,
        /// <summary>
        ///
        /// </summary>
        PlacementGroup,
        /// <summary>
        ///
        /// </summary>
        PlacementType,
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersion,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        StateDetails,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.RetentionMessageVersion => "retentionMessageVersion",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.State => "state",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "retentionMessageVersion" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.RetentionMessageVersion,
                "state" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => RetentionMessagesVersionsGetToManyRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}