
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppCustomProductPagesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppCustomProductPagesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppCustomProductPagesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppCustomProductPagesGetToManyRelatedIncludeItem.App => "app",
                AppsAppCustomProductPagesGetToManyRelatedIncludeItem.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppCustomProductPagesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppCustomProductPagesGetToManyRelatedIncludeItem.App,
                "appCustomProductPageVersions" => AppsAppCustomProductPagesGetToManyRelatedIncludeItem.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}