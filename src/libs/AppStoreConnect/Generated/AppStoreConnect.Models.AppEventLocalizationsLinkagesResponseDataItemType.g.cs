
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppEventLocalizationsLinkagesResponseDataItemType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppEventLocalizationsLinkagesResponseDataItemType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}