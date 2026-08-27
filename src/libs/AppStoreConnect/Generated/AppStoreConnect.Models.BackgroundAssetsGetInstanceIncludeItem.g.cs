
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        ExternalBetaVersion,
        /// <summary>
        ///
        /// </summary>
        InternalBetaVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsGetInstanceIncludeItem value)
        {
            return value switch
            {
                BackgroundAssetsGetInstanceIncludeItem.App => "app",
                BackgroundAssetsGetInstanceIncludeItem.AppStoreVersion => "appStoreVersion",
                BackgroundAssetsGetInstanceIncludeItem.ExternalBetaVersion => "externalBetaVersion",
                BackgroundAssetsGetInstanceIncludeItem.InternalBetaVersion => "internalBetaVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => BackgroundAssetsGetInstanceIncludeItem.App,
                "appStoreVersion" => BackgroundAssetsGetInstanceIncludeItem.AppStoreVersion,
                "externalBetaVersion" => BackgroundAssetsGetInstanceIncludeItem.ExternalBetaVersion,
                "internalBetaVersion" => BackgroundAssetsGetInstanceIncludeItem.InternalBetaVersion,
                _ => null,
            };
        }
    }
}