
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                AppEventRelationshipsLocalizationsDataItemType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppEventRelationshipsLocalizationsDataItemType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}