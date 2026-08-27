
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoAppInfoLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfoLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoAppInfoLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoAppInfoLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppInfoAppInfoLocalizationsLinkagesResponseDataItemType.AppInfoLocalizations => "appInfoLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoAppInfoLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appInfoLocalizations" => AppInfoAppInfoLocalizationsLinkagesResponseDataItemType.AppInfoLocalizations,
                _ => null,
            };
        }
    }
}