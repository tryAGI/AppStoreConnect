
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAppStoreVersionsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppStoreVersionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppStoreVersionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppStoreVersionsLinkagesResponseDataItemType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppStoreVersionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppAppStoreVersionsLinkagesResponseDataItemType.AppStoreVersions,
                _ => null,
            };
        }
    }
}