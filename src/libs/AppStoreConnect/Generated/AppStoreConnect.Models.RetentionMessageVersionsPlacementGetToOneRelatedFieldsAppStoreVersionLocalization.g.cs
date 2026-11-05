
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization
    {
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
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        Keywords,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        MarketingUrl,
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
        /// <summary>
        ///
        /// </summary>
        SupportUrl,
        /// <summary>
        ///
        /// </summary>
        WhatsNew,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.Description => "description",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.Placements => "placements",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "placements" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.Placements,
                "promotionalText" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => RetentionMessageVersionsPlacementGetToOneRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}