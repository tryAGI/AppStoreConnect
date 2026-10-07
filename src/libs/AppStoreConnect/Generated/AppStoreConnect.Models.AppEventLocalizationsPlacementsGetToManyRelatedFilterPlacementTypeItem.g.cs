
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppPreview,
        /// <summary>
        ///
        /// </summary>
        AppScreenshot,
        /// <summary>
        ///
        /// </summary>
        AppStoreSearchResultsAsset,
        /// <summary>
        ///
        /// </summary>
        EventCardAsset,
        /// <summary>
        ///
        /// </summary>
        EventDetailsPageAsset,
        /// <summary>
        ///
        /// </summary>
        ImessageAppScreenshot,
        /// <summary>
        ///
        /// </summary>
        ProductPageHeaderAsset,
        /// <summary>
        ///
        /// </summary>
        RetentionMessageAsset,
        /// <summary>
        ///
        /// </summary>
        SearchResultsAdsAsset,
        /// <summary>
        ///
        /// </summary>
        TodayTabAdsAsset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview => "APP_PREVIEW",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot => "APP_SCREENSHOT",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset => "APP_STORE_SEARCH_RESULTS_ASSET",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset => "EVENT_CARD_ASSET",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset => "EVENT_DETAILS_PAGE_ASSET",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot => "IMESSAGE_APP_SCREENSHOT",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset => "PRODUCT_PAGE_HEADER_ASSET",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset => "RETENTION_MESSAGE_ASSET",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset => "SEARCH_RESULTS_ADS_ASSET",
                AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset => "TODAY_TAB_ADS_ASSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_PREVIEW" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview,
                "APP_SCREENSHOT" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot,
                "APP_STORE_SEARCH_RESULTS_ASSET" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset,
                "EVENT_CARD_ASSET" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset,
                "EVENT_DETAILS_PAGE_ASSET" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset,
                "IMESSAGE_APP_SCREENSHOT" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot,
                "PRODUCT_PAGE_HEADER_ASSET" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset,
                "RETENTION_MESSAGE_ASSET" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset,
                "SEARCH_RESULTS_ADS_ASSET" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset,
                "TODAY_TAB_ADS_ASSET" => AppEventLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset,
                _ => null,
            };
        }
    }
}