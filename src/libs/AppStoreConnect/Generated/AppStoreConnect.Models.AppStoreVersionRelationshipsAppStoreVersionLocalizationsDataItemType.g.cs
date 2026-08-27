
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppStoreVersionRelationshipsAppStoreVersionLocalizationsDataItemType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}