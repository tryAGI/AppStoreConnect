
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RoutingAppCoveragesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoutingAppCoveragesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoutingAppCoveragesGetInstanceIncludeItem value)
        {
            return value switch
            {
                RoutingAppCoveragesGetInstanceIncludeItem.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoutingAppCoveragesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => RoutingAppCoveragesGetInstanceIncludeItem.AppStoreVersion,
                _ => null,
            };
        }
    }
}