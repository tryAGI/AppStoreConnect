
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement
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
    public static class RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.RetentionMessageVersion => "retentionMessageVersion",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.State => "state",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "retentionMessageVersion" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.RetentionMessageVersion,
                "state" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => RetentionMessageVersionsGetInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}