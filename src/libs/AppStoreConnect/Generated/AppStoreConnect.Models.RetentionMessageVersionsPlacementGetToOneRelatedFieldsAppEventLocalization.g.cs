
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization
    {
        /// <summary>
        ///
        /// </summary>
        AppEvent,
        /// <summary>
        ///
        /// </summary>
        AppEventScreenshots,
        /// <summary>
        ///
        /// </summary>
        AppEventVideoClips,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        LongDescription,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Placements,
        /// <summary>
        ///
        /// </summary>
        ShortDescription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.Locale => "locale",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.Name => "name",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.Placements => "placements",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.LongDescription,
                "name" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.Name,
                "placements" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.Placements,
                "shortDescription" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}