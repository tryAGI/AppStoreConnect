
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview => "APP_PREVIEW",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot => "APP_SCREENSHOT",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset => "APP_STORE_SEARCH_RESULTS_ASSET",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset => "EVENT_CARD_ASSET",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset => "EVENT_DETAILS_PAGE_ASSET",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot => "IMESSAGE_APP_SCREENSHOT",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset => "PRODUCT_PAGE_HEADER_ASSET",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset => "RETENTION_MESSAGE_ASSET",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset => "SEARCH_RESULTS_ADS_ASSET",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset => "TODAY_TAB_ADS_ASSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_PREVIEW" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.AppPreview,
                "APP_SCREENSHOT" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.AppScreenshot,
                "APP_STORE_SEARCH_RESULTS_ASSET" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.AppStoreSearchResultsAsset,
                "EVENT_CARD_ASSET" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.EventCardAsset,
                "EVENT_DETAILS_PAGE_ASSET" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.EventDetailsPageAsset,
                "IMESSAGE_APP_SCREENSHOT" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.ImessageAppScreenshot,
                "PRODUCT_PAGE_HEADER_ASSET" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.ProductPageHeaderAsset,
                "RETENTION_MESSAGE_ASSET" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.RetentionMessageAsset,
                "SEARCH_RESULTS_ADS_ASSET" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.SearchResultsAdsAsset,
                "TODAY_TAB_ADS_ASSET" => AppAssetLibraryVideosPlacementsGetToManyRelatedFilterPlacementTypeItem.TodayTabAdsAsset,
                _ => null,
            };
        }
    }
}