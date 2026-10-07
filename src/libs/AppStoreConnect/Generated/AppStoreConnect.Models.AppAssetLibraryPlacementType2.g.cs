
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementType2
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
    public static class AppAssetLibraryPlacementType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementType2 value)
        {
            return value switch
            {
                AppAssetLibraryPlacementType2.AppPreview => "APP_PREVIEW",
                AppAssetLibraryPlacementType2.AppScreenshot => "APP_SCREENSHOT",
                AppAssetLibraryPlacementType2.AppStoreSearchResultsAsset => "APP_STORE_SEARCH_RESULTS_ASSET",
                AppAssetLibraryPlacementType2.EventCardAsset => "EVENT_CARD_ASSET",
                AppAssetLibraryPlacementType2.EventDetailsPageAsset => "EVENT_DETAILS_PAGE_ASSET",
                AppAssetLibraryPlacementType2.ImessageAppScreenshot => "IMESSAGE_APP_SCREENSHOT",
                AppAssetLibraryPlacementType2.ProductPageHeaderAsset => "PRODUCT_PAGE_HEADER_ASSET",
                AppAssetLibraryPlacementType2.RetentionMessageAsset => "RETENTION_MESSAGE_ASSET",
                AppAssetLibraryPlacementType2.SearchResultsAdsAsset => "SEARCH_RESULTS_ADS_ASSET",
                AppAssetLibraryPlacementType2.TodayTabAdsAsset => "TODAY_TAB_ADS_ASSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementType2? ToEnum(string value)
        {
            return value switch
            {
                "APP_PREVIEW" => AppAssetLibraryPlacementType2.AppPreview,
                "APP_SCREENSHOT" => AppAssetLibraryPlacementType2.AppScreenshot,
                "APP_STORE_SEARCH_RESULTS_ASSET" => AppAssetLibraryPlacementType2.AppStoreSearchResultsAsset,
                "EVENT_CARD_ASSET" => AppAssetLibraryPlacementType2.EventCardAsset,
                "EVENT_DETAILS_PAGE_ASSET" => AppAssetLibraryPlacementType2.EventDetailsPageAsset,
                "IMESSAGE_APP_SCREENSHOT" => AppAssetLibraryPlacementType2.ImessageAppScreenshot,
                "PRODUCT_PAGE_HEADER_ASSET" => AppAssetLibraryPlacementType2.ProductPageHeaderAsset,
                "RETENTION_MESSAGE_ASSET" => AppAssetLibraryPlacementType2.RetentionMessageAsset,
                "SEARCH_RESULTS_ADS_ASSET" => AppAssetLibraryPlacementType2.SearchResultsAdsAsset,
                "TODAY_TAB_ADS_ASSET" => AppAssetLibraryPlacementType2.TodayTabAdsAsset,
                _ => null,
            };
        }
    }
}