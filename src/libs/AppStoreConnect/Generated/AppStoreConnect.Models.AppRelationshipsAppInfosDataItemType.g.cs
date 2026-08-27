
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsAppInfosDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsAppInfosDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsAppInfosDataItemType value)
        {
            return value switch
            {
                AppRelationshipsAppInfosDataItemType.AppInfos => "appInfos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsAppInfosDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appInfos" => AppRelationshipsAppInfosDataItemType.AppInfos,
                _ => null,
            };
        }
    }
}