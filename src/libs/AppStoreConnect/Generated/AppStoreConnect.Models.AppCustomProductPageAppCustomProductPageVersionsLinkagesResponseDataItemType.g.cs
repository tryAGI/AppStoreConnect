
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageAppCustomProductPageVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageAppCustomProductPageVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageAppCustomProductPageVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageAppCustomProductPageVersionsLinkagesResponseDataItemType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageAppCustomProductPageVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageAppCustomProductPageVersionsLinkagesResponseDataItemType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}