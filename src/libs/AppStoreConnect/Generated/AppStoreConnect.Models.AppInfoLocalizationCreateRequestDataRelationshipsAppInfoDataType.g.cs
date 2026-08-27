
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoLocalizationCreateRequestDataRelationshipsAppInfoDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppInfos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoLocalizationCreateRequestDataRelationshipsAppInfoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoLocalizationCreateRequestDataRelationshipsAppInfoDataType value)
        {
            return value switch
            {
                AppInfoLocalizationCreateRequestDataRelationshipsAppInfoDataType.AppInfos => "appInfos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoLocalizationCreateRequestDataRelationshipsAppInfoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appInfos" => AppInfoLocalizationCreateRequestDataRelationshipsAppInfoDataType.AppInfos,
                _ => null,
            };
        }
    }
}