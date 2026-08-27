
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
        /// <summary>
        /// 
        /// </summary>
        CompatibilityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem.CompatibilityVersions => "compatibilityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem.AppStoreVersion,
                "compatibilityVersions" => AppStoreVersionsGameCenterAppVersionGetToOneRelatedIncludeItem.CompatibilityVersions,
                _ => null,
            };
        }
    }
}