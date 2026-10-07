
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryFeature
    {
        /// <summary>
        ///
        /// </summary>
        AppleAds,
        /// <summary>
        ///
        /// </summary>
        AppClips,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
        /// <summary>
        ///
        /// </summary>
        CustomProductPages,
        /// <summary>
        ///
        /// </summary>
        GameCenter,
        /// <summary>
        ///
        /// </summary>
        InAppEvents,
        /// <summary>
        ///
        /// </summary>
        InAppPurchases,
        /// <summary>
        ///
        /// </summary>
        ProductPageOptimizations,
        /// <summary>
        ///
        /// </summary>
        RetentionMessaging,
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryFeatureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryFeature value)
        {
            return value switch
            {
                AppAssetLibraryFeature.AppleAds => "APPLE_ADS",
                AppAssetLibraryFeature.AppClips => "APP_CLIPS",
                AppAssetLibraryFeature.AppStoreVersions => "APP_STORE_VERSIONS",
                AppAssetLibraryFeature.CustomProductPages => "CUSTOM_PRODUCT_PAGES",
                AppAssetLibraryFeature.GameCenter => "GAME_CENTER",
                AppAssetLibraryFeature.InAppEvents => "IN_APP_EVENTS",
                AppAssetLibraryFeature.InAppPurchases => "IN_APP_PURCHASES",
                AppAssetLibraryFeature.ProductPageOptimizations => "PRODUCT_PAGE_OPTIMIZATIONS",
                AppAssetLibraryFeature.RetentionMessaging => "RETENTION_MESSAGING",
                AppAssetLibraryFeature.Subscriptions => "SUBSCRIPTIONS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryFeature? ToEnum(string value)
        {
            return value switch
            {
                "APPLE_ADS" => AppAssetLibraryFeature.AppleAds,
                "APP_CLIPS" => AppAssetLibraryFeature.AppClips,
                "APP_STORE_VERSIONS" => AppAssetLibraryFeature.AppStoreVersions,
                "CUSTOM_PRODUCT_PAGES" => AppAssetLibraryFeature.CustomProductPages,
                "GAME_CENTER" => AppAssetLibraryFeature.GameCenter,
                "IN_APP_EVENTS" => AppAssetLibraryFeature.InAppEvents,
                "IN_APP_PURCHASES" => AppAssetLibraryFeature.InAppPurchases,
                "PRODUCT_PAGE_OPTIMIZATIONS" => AppAssetLibraryFeature.ProductPageOptimizations,
                "RETENTION_MESSAGING" => AppAssetLibraryFeature.RetentionMessaging,
                "SUBSCRIPTIONS" => AppAssetLibraryFeature.Subscriptions,
                _ => null,
            };
        }
    }
}