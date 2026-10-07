
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement
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
    public static class AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement value)
        {
            return value switch
            {
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization => "appEventLocalization",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization => "appStoreVersionLocalization",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.CreatedDate => "createdDate",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.Image => "image",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate => "lastModifiedDate",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.MediaType => "mediaType",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.PlacementGroup => "placementGroup",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.PlacementType => "placementType",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.State => "state",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.StateDetails => "stateDetails",
                AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.AppCustomProductPageLocalization,
                "appEventLocalization" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.AppStoreVersionLocalization,
                "createdDate" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.CreatedDate,
                "image" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.Image,
                "lastModifiedDate" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.LastModifiedDate,
                "mediaType" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.MediaType,
                "placementGroup" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.PlacementGroup,
                "placementType" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.PlacementType,
                "state" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.State,
                "stateDetails" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.StateDetails,
                "video" => AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement.Video,
                _ => null,
            };
        }
    }
}