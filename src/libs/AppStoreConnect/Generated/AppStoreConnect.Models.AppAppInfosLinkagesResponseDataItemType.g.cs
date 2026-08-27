
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAppInfosLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppInfos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppInfosLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppInfosLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppInfosLinkagesResponseDataItemType.AppInfos => "appInfos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppInfosLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appInfos" => AppAppInfosLinkagesResponseDataItemType.AppInfos,
                _ => null,
            };
        }
    }
}