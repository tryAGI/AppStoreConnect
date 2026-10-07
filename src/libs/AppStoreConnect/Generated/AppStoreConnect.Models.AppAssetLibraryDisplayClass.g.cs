
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryDisplayClass
    {
        /// <summary>
        ///
        /// </summary>
        Default,
        /// <summary>
        ///
        /// </summary>
        Ipad105Display,
        /// <summary>
        ///
        /// </summary>
        Ipad11Display,
        /// <summary>
        ///
        /// </summary>
        Ipad129Display,
        /// <summary>
        ///
        /// </summary>
        Ipad13Display,
        /// <summary>
        ///
        /// </summary>
        Ipad97Display,
        /// <summary>
        ///
        /// </summary>
        IphoneDuo,
        /// <summary>
        ///
        /// </summary>
        IphoneDynamicIslandLargeDisplay,
        /// <summary>
        ///
        /// </summary>
        IphoneDynamicIslandMediumDisplay,
        /// <summary>
        ///
        /// </summary>
        IphoneFaceIdLargeDisplay,
        /// <summary>
        ///
        /// </summary>
        IphoneFaceIdMediumDisplay,
        /// <summary>
        ///
        /// </summary>
        IphoneHomeButton35Display,
        /// <summary>
        ///
        /// </summary>
        IphoneHomeButton40Display,
        /// <summary>
        ///
        /// </summary>
        IphoneHomeButtonLargeDisplay,
        /// <summary>
        ///
        /// </summary>
        IphoneHomeButtonMediumDisplay,
        /// <summary>
        ///
        /// </summary>
        WatchSeries10,
        /// <summary>
        ///
        /// </summary>
        WatchSeries3,
        /// <summary>
        ///
        /// </summary>
        WatchSeries4,
        /// <summary>
        ///
        /// </summary>
        WatchSeries7,
        /// <summary>
        ///
        /// </summary>
        WatchUltra,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryDisplayClassExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryDisplayClass value)
        {
            return value switch
            {
                AppAssetLibraryDisplayClass.Default => "DEFAULT",
                AppAssetLibraryDisplayClass.Ipad105Display => "IPAD_105_DISPLAY",
                AppAssetLibraryDisplayClass.Ipad11Display => "IPAD_11_DISPLAY",
                AppAssetLibraryDisplayClass.Ipad129Display => "IPAD_129_DISPLAY",
                AppAssetLibraryDisplayClass.Ipad13Display => "IPAD_13_DISPLAY",
                AppAssetLibraryDisplayClass.Ipad97Display => "IPAD_97_DISPLAY",
                AppAssetLibraryDisplayClass.IphoneDuo => "IPHONE_DUO",
                AppAssetLibraryDisplayClass.IphoneDynamicIslandLargeDisplay => "IPHONE_DYNAMIC_ISLAND_LARGE_DISPLAY",
                AppAssetLibraryDisplayClass.IphoneDynamicIslandMediumDisplay => "IPHONE_DYNAMIC_ISLAND_MEDIUM_DISPLAY",
                AppAssetLibraryDisplayClass.IphoneFaceIdLargeDisplay => "IPHONE_FACE_ID_LARGE_DISPLAY",
                AppAssetLibraryDisplayClass.IphoneFaceIdMediumDisplay => "IPHONE_FACE_ID_MEDIUM_DISPLAY",
                AppAssetLibraryDisplayClass.IphoneHomeButton35Display => "IPHONE_HOME_BUTTON_35_DISPLAY",
                AppAssetLibraryDisplayClass.IphoneHomeButton40Display => "IPHONE_HOME_BUTTON_40_DISPLAY",
                AppAssetLibraryDisplayClass.IphoneHomeButtonLargeDisplay => "IPHONE_HOME_BUTTON_LARGE_DISPLAY",
                AppAssetLibraryDisplayClass.IphoneHomeButtonMediumDisplay => "IPHONE_HOME_BUTTON_MEDIUM_DISPLAY",
                AppAssetLibraryDisplayClass.WatchSeries10 => "WATCH_SERIES_10",
                AppAssetLibraryDisplayClass.WatchSeries3 => "WATCH_SERIES_3",
                AppAssetLibraryDisplayClass.WatchSeries4 => "WATCH_SERIES_4",
                AppAssetLibraryDisplayClass.WatchSeries7 => "WATCH_SERIES_7",
                AppAssetLibraryDisplayClass.WatchUltra => "WATCH_ULTRA",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryDisplayClass? ToEnum(string value)
        {
            return value switch
            {
                "DEFAULT" => AppAssetLibraryDisplayClass.Default,
                "IPAD_105_DISPLAY" => AppAssetLibraryDisplayClass.Ipad105Display,
                "IPAD_11_DISPLAY" => AppAssetLibraryDisplayClass.Ipad11Display,
                "IPAD_129_DISPLAY" => AppAssetLibraryDisplayClass.Ipad129Display,
                "IPAD_13_DISPLAY" => AppAssetLibraryDisplayClass.Ipad13Display,
                "IPAD_97_DISPLAY" => AppAssetLibraryDisplayClass.Ipad97Display,
                "IPHONE_DUO" => AppAssetLibraryDisplayClass.IphoneDuo,
                "IPHONE_DYNAMIC_ISLAND_LARGE_DISPLAY" => AppAssetLibraryDisplayClass.IphoneDynamicIslandLargeDisplay,
                "IPHONE_DYNAMIC_ISLAND_MEDIUM_DISPLAY" => AppAssetLibraryDisplayClass.IphoneDynamicIslandMediumDisplay,
                "IPHONE_FACE_ID_LARGE_DISPLAY" => AppAssetLibraryDisplayClass.IphoneFaceIdLargeDisplay,
                "IPHONE_FACE_ID_MEDIUM_DISPLAY" => AppAssetLibraryDisplayClass.IphoneFaceIdMediumDisplay,
                "IPHONE_HOME_BUTTON_35_DISPLAY" => AppAssetLibraryDisplayClass.IphoneHomeButton35Display,
                "IPHONE_HOME_BUTTON_40_DISPLAY" => AppAssetLibraryDisplayClass.IphoneHomeButton40Display,
                "IPHONE_HOME_BUTTON_LARGE_DISPLAY" => AppAssetLibraryDisplayClass.IphoneHomeButtonLargeDisplay,
                "IPHONE_HOME_BUTTON_MEDIUM_DISPLAY" => AppAssetLibraryDisplayClass.IphoneHomeButtonMediumDisplay,
                "WATCH_SERIES_10" => AppAssetLibraryDisplayClass.WatchSeries10,
                "WATCH_SERIES_3" => AppAssetLibraryDisplayClass.WatchSeries3,
                "WATCH_SERIES_4" => AppAssetLibraryDisplayClass.WatchSeries4,
                "WATCH_SERIES_7" => AppAssetLibraryDisplayClass.WatchSeries7,
                "WATCH_ULTRA" => AppAssetLibraryDisplayClass.WatchUltra,
                _ => null,
            };
        }
    }
}