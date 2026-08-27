
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetInstanceFieldsPreReleaseVersion
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Builds,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsGetInstanceFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsPreReleaseVersion value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsPreReleaseVersion.App => "app",
                BuildsGetInstanceFieldsPreReleaseVersion.Builds => "builds",
                BuildsGetInstanceFieldsPreReleaseVersion.Platform => "platform",
                BuildsGetInstanceFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetInstanceFieldsPreReleaseVersion.App,
                "builds" => BuildsGetInstanceFieldsPreReleaseVersion.Builds,
                "platform" => BuildsGetInstanceFieldsPreReleaseVersion.Platform,
                "version" => BuildsGetInstanceFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}