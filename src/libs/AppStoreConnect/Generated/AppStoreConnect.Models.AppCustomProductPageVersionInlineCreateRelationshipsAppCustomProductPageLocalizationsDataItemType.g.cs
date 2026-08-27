
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizationsDataItemType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}