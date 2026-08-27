
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageLocalizationsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageLocalizationsDataItemType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageLocalizationsDataItemType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}