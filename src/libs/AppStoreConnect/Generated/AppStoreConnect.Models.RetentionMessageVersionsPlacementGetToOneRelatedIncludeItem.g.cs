
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem
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
        Image,
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersion,
        /// <summary>
        ///
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsPlacementGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.AppCustomProductPageLocalization => "appCustomProductPageLocalization",
                RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.AppEventLocalization => "appEventLocalization",
                RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization => "appStoreVersionExperimentTreatmentLocalization",
                RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.AppStoreVersionLocalization => "appStoreVersionLocalization",
                RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.Image => "image",
                RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.RetentionMessageVersion => "retentionMessageVersion",
                RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalization" => RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.AppCustomProductPageLocalization,
                "appEventLocalization" => RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.AppEventLocalization,
                "appStoreVersionExperimentTreatmentLocalization" => RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalization,
                "appStoreVersionLocalization" => RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.AppStoreVersionLocalization,
                "image" => RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.Image,
                "retentionMessageVersion" => RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.RetentionMessageVersion,
                "video" => RetentionMessageVersionsPlacementGetToOneRelatedIncludeItem.Video,
                _ => null,
            };
        }
    }
}