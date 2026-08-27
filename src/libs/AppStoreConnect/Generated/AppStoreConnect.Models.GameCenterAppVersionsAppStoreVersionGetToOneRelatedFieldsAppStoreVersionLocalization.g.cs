
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Description => "description",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}