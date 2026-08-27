
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreReleaseVersionsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreReleaseVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                PreReleaseVersionsGetInstanceIncludeItem.App => "app",
                PreReleaseVersionsGetInstanceIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => PreReleaseVersionsGetInstanceIncludeItem.App,
                "builds" => PreReleaseVersionsGetInstanceIncludeItem.Builds,
                _ => null,
            };
        }
    }
}