
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersion,
        /// <summary>
        ///
        /// </summary>
        AppPreviewSets,
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Placements,
        /// <summary>
        ///
        /// </summary>
        PromotionalText,
        /// <summary>
        ///
        /// </summary>
        SearchKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.Locale => "locale",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.Placements => "placements",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.Locale,
                "placements" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.Placements,
                "promotionalText" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}