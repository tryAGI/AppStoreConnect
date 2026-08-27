
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsRoutingAppCoverageGetToOneRelatedIncludeItem.AppStoreVersion,
                _ => null,
            };
        }
    }
}