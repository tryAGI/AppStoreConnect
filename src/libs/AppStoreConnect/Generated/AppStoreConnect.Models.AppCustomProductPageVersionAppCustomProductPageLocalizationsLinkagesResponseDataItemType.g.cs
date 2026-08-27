
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageVersionAppCustomProductPageLocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionAppCustomProductPageLocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionAppCustomProductPageLocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageVersionAppCustomProductPageLocalizationsLinkagesResponseDataItemType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionAppCustomProductPageLocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppCustomProductPageVersionAppCustomProductPageLocalizationsLinkagesResponseDataItemType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}