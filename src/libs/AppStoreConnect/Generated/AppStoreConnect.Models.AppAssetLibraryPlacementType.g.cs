
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementType
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
    public static class AppAssetLibraryPlacementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementType value)
        {
            return value switch
            {
                AppAssetLibraryPlacementType.AppPreview => "APP_PREVIEW",
                AppAssetLibraryPlacementType.AppScreenshot => "APP_SCREENSHOT",
                AppAssetLibraryPlacementType.AppStoreSearchResultsAsset => "APP_STORE_SEARCH_RESULTS_ASSET",
                AppAssetLibraryPlacementType.EventCardAsset => "EVENT_CARD_ASSET",
                AppAssetLibraryPlacementType.EventDetailsPageAsset => "EVENT_DETAILS_PAGE_ASSET",
                AppAssetLibraryPlacementType.ImessageAppScreenshot => "IMESSAGE_APP_SCREENSHOT",
                AppAssetLibraryPlacementType.ProductPageHeaderAsset => "PRODUCT_PAGE_HEADER_ASSET",
                AppAssetLibraryPlacementType.RetentionMessageAsset => "RETENTION_MESSAGE_ASSET",
                AppAssetLibraryPlacementType.SearchResultsAdsAsset => "SEARCH_RESULTS_ADS_ASSET",
                AppAssetLibraryPlacementType.TodayTabAdsAsset => "TODAY_TAB_ADS_ASSET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementType? ToEnum(string value)
        {
            return value switch
            {
                "APP_PREVIEW" => AppAssetLibraryPlacementType.AppPreview,
                "APP_SCREENSHOT" => AppAssetLibraryPlacementType.AppScreenshot,
                "APP_STORE_SEARCH_RESULTS_ASSET" => AppAssetLibraryPlacementType.AppStoreSearchResultsAsset,
                "EVENT_CARD_ASSET" => AppAssetLibraryPlacementType.EventCardAsset,
                "EVENT_DETAILS_PAGE_ASSET" => AppAssetLibraryPlacementType.EventDetailsPageAsset,
                "IMESSAGE_APP_SCREENSHOT" => AppAssetLibraryPlacementType.ImessageAppScreenshot,
                "PRODUCT_PAGE_HEADER_ASSET" => AppAssetLibraryPlacementType.ProductPageHeaderAsset,
                "RETENTION_MESSAGE_ASSET" => AppAssetLibraryPlacementType.RetentionMessageAsset,
                "SEARCH_RESULTS_ADS_ASSET" => AppAssetLibraryPlacementType.SearchResultsAdsAsset,
                "TODAY_TAB_ADS_ASSET" => AppAssetLibraryPlacementType.TodayTabAdsAsset,
                _ => null,
            };
        }
    }
}