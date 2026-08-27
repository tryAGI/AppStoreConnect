
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppStoreVersionAppStoreVersionLocalizationsLinkagesResponseDataItemType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}