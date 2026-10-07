
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementPlatform
    {
        /// <summary>
        ///
        /// </summary>
        Any,
        /// <summary>
        ///
        /// </summary>
        ImessageAppStore,
        /// <summary>
        ///
        /// </summary>
        IpadAppStore,
        /// <summary>
        ///
        /// </summary>
        IphoneAppStore,
        /// <summary>
        ///
        /// </summary>
        MacAppStore,
        /// <summary>
        ///
        /// </summary>
        TvAppStore,
        /// <summary>
        ///
        /// </summary>
        VisionProAppStore,
        /// <summary>
        ///
        /// </summary>
        WatchAppStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementPlatform value)
        {
            return value switch
            {
                AppAssetLibraryPlacementPlatform.Any => "ANY",
                AppAssetLibraryPlacementPlatform.ImessageAppStore => "IMESSAGE_APP_STORE",
                AppAssetLibraryPlacementPlatform.IpadAppStore => "IPAD_APP_STORE",
                AppAssetLibraryPlacementPlatform.IphoneAppStore => "IPHONE_APP_STORE",
                AppAssetLibraryPlacementPlatform.MacAppStore => "MAC_APP_STORE",
                AppAssetLibraryPlacementPlatform.TvAppStore => "TV_APP_STORE",
                AppAssetLibraryPlacementPlatform.VisionProAppStore => "VISION_PRO_APP_STORE",
                AppAssetLibraryPlacementPlatform.WatchAppStore => "WATCH_APP_STORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementPlatform? ToEnum(string value)
        {
            return value switch
            {
                "ANY" => AppAssetLibraryPlacementPlatform.Any,
                "IMESSAGE_APP_STORE" => AppAssetLibraryPlacementPlatform.ImessageAppStore,
                "IPAD_APP_STORE" => AppAssetLibraryPlacementPlatform.IpadAppStore,
                "IPHONE_APP_STORE" => AppAssetLibraryPlacementPlatform.IphoneAppStore,
                "MAC_APP_STORE" => AppAssetLibraryPlacementPlatform.MacAppStore,
                "TV_APP_STORE" => AppAssetLibraryPlacementPlatform.TvAppStore,
                "VISION_PRO_APP_STORE" => AppAssetLibraryPlacementPlatform.VisionProAppStore,
                "WATCH_APP_STORE" => AppAssetLibraryPlacementPlatform.WatchAppStore,
                _ => null,
            };
        }
    }
}