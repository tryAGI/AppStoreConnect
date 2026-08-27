
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization
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
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Description => "description",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}