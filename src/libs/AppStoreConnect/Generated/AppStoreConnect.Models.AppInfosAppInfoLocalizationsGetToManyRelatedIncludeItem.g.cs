
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppInfo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem.AppInfo => "appInfo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appInfo" => AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem.AppInfo,
                _ => null,
            };
        }
    }
}