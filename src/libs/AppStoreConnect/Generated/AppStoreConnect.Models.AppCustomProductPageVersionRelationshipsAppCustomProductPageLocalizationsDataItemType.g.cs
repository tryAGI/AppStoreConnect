
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizationsDataItemType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}