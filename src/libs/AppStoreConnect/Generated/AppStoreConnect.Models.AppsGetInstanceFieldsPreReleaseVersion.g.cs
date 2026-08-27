
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsPreReleaseVersion
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
    public static class AppsGetInstanceFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsPreReleaseVersion value)
        {
            return value switch
            {
                AppsGetInstanceFieldsPreReleaseVersion.App => "app",
                AppsGetInstanceFieldsPreReleaseVersion.Builds => "builds",
                AppsGetInstanceFieldsPreReleaseVersion.Platform => "platform",
                AppsGetInstanceFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsPreReleaseVersion.App,
                "builds" => AppsGetInstanceFieldsPreReleaseVersion.Builds,
                "platform" => AppsGetInstanceFieldsPreReleaseVersion.Platform,
                "version" => AppsGetInstanceFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}