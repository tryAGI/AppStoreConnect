
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizationsDataItemType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}