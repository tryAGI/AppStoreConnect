
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem
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
    public static class AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview => "APP_PREVIEW",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot => "APP_SCREENSHOT",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset => "APP_STORE_SEARCH_RESULTS_ASSET",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset => "EVENT_CARD_ASSET",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset => "EVENT_DETAILS_PAGE_ASSET",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot => "IMESSAGE_APP_SCREENSHOT",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset => "PRODUCT_PAGE_HEADER_ASSET",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset => "RETENTION_MESSAGE_ASSET",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset => "SEARCH_RESULTS_ADS_ASSET",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset => "TODAY_TAB_ADS_ASSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_PREVIEW" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview,
                "APP_SCREENSHOT" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot,
                "APP_STORE_SEARCH_RESULTS_ASSET" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset,
                "EVENT_CARD_ASSET" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset,
                "EVENT_DETAILS_PAGE_ASSET" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset,
                "IMESSAGE_APP_SCREENSHOT" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot,
                "PRODUCT_PAGE_HEADER_ASSET" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset,
                "RETENTION_MESSAGE_ASSET" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset,
                "SEARCH_RESULTS_ADS_ASSET" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset,
                "TODAY_TAB_ADS_ASSET" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset,
                _ => null,
            };
        }
    }
}