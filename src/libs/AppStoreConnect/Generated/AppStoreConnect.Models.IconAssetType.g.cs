
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum IconAssetType
    {
        /// <summary>
        ///
        /// </summary>
        AlternateExperiment,
        /// <summary>
        ///
        /// </summary>
        AppStore,
        /// <summary>
        ///
        /// </summary>
        MessagesAppStore,
        /// <summary>
        ///
        /// </summary>
        TvOsHomeScreen,
        /// <summary>
        ///
        /// </summary>
        TvOsTopShelf,
        /// <summary>
        ///
        /// </summary>
        WatchAppStore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IconAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IconAssetType value)
        {
            return value switch
            {
                IconAssetType.AlternateExperiment => "ALTERNATE_EXPERIMENT",
                IconAssetType.AppStore => "APP_STORE",
                IconAssetType.MessagesAppStore => "MESSAGES_APP_STORE",
                IconAssetType.TvOsHomeScreen => "TV_OS_HOME_SCREEN",
                IconAssetType.TvOsTopShelf => "TV_OS_TOP_SHELF",
                IconAssetType.WatchAppStore => "WATCH_APP_STORE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IconAssetType? ToEnum(string value)
        {
            return value switch
            {
                "ALTERNATE_EXPERIMENT" => IconAssetType.AlternateExperiment,
                "APP_STORE" => IconAssetType.AppStore,
                "MESSAGES_APP_STORE" => IconAssetType.MessagesAppStore,
                "TV_OS_HOME_SCREEN" => IconAssetType.TvOsHomeScreen,
                "TV_OS_TOP_SHELF" => IconAssetType.TvOsTopShelf,
                "WATCH_APP_STORE" => IconAssetType.WatchAppStore,
                _ => null,
            };
        }
    }
}