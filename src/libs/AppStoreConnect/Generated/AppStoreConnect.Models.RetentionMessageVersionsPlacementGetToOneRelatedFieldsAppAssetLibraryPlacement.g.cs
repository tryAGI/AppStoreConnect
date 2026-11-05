
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement
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
    public static class RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.Image => "image",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.RetentionMessageVersion => "retentionMessageVersion",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.State => "state",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.PlacementType,
                "retentionMessageVersion" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.RetentionMessageVersion,
                "state" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}