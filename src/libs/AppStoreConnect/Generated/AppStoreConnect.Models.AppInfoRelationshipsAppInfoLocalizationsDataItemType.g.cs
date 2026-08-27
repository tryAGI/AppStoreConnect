
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoRelationshipsAppInfoLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfoLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoRelationshipsAppInfoLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoRelationshipsAppInfoLocalizationsDataItemType value)
        {
            return value switch
            {
                AppInfoRelationshipsAppInfoLocalizationsDataItemType.AppInfoLocalizations => "appInfoLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoRelationshipsAppInfoLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appInfoLocalizations" => AppInfoRelationshipsAppInfoLocalizationsDataItemType.AppInfoLocalizations,
                _ => null,
            };
        }
    }
}