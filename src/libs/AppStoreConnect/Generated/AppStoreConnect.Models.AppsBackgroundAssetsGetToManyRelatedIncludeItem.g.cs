
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsBackgroundAssetsGetToManyRelatedIncludeItem
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
    public static class AppsBackgroundAssetsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsBackgroundAssetsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsBackgroundAssetsGetToManyRelatedIncludeItem.App => "app",
                AppsBackgroundAssetsGetToManyRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                AppsBackgroundAssetsGetToManyRelatedIncludeItem.ExternalBetaVersion => "externalBetaVersion",
                AppsBackgroundAssetsGetToManyRelatedIncludeItem.InternalBetaVersion => "internalBetaVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsBackgroundAssetsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsBackgroundAssetsGetToManyRelatedIncludeItem.App,
                "appStoreVersion" => AppsBackgroundAssetsGetToManyRelatedIncludeItem.AppStoreVersion,
                "externalBetaVersion" => AppsBackgroundAssetsGetToManyRelatedIncludeItem.ExternalBetaVersion,
                "internalBetaVersion" => AppsBackgroundAssetsGetToManyRelatedIncludeItem.InternalBetaVersion,
                _ => null,
            };
        }
    }
}