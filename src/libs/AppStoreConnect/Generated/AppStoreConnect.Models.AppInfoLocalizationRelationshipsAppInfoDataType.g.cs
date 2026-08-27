
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoLocalizationRelationshipsAppInfoDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppInfos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoLocalizationRelationshipsAppInfoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoLocalizationRelationshipsAppInfoDataType value)
        {
            return value switch
            {
                AppInfoLocalizationRelationshipsAppInfoDataType.AppInfos => "appInfos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoLocalizationRelationshipsAppInfoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appInfos" => AppInfoLocalizationRelationshipsAppInfoDataType.AppInfos,
                _ => null,
            };
        }
    }
}