
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem
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
    public static class AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview => "APP_PREVIEW",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot => "APP_SCREENSHOT",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset => "APP_STORE_SEARCH_RESULTS_ASSET",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset => "EVENT_CARD_ASSET",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset => "EVENT_DETAILS_PAGE_ASSET",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot => "IMESSAGE_APP_SCREENSHOT",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset => "PRODUCT_PAGE_HEADER_ASSET",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset => "RETENTION_MESSAGE_ASSET",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset => "SEARCH_RESULTS_ADS_ASSET",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset => "TODAY_TAB_ADS_ASSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_PREVIEW" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview,
                "APP_SCREENSHOT" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot,
                "APP_STORE_SEARCH_RESULTS_ASSET" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset,
                "EVENT_CARD_ASSET" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset,
                "EVENT_DETAILS_PAGE_ASSET" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset,
                "IMESSAGE_APP_SCREENSHOT" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot,
                "PRODUCT_PAGE_HEADER_ASSET" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset,
                "RETENTION_MESSAGE_ASSET" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset,
                "SEARCH_RESULTS_ADS_ASSET" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset,
                "TODAY_TAB_ADS_ASSET" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset,
                _ => null,
            };
        }
    }
}