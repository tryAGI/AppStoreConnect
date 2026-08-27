
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreReleaseVersionsGetInstanceFieldsPreReleaseVersion
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
    public static class PreReleaseVersionsGetInstanceFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetInstanceFieldsPreReleaseVersion value)
        {
            return value switch
            {
                PreReleaseVersionsGetInstanceFieldsPreReleaseVersion.App => "app",
                PreReleaseVersionsGetInstanceFieldsPreReleaseVersion.Builds => "builds",
                PreReleaseVersionsGetInstanceFieldsPreReleaseVersion.Platform => "platform",
                PreReleaseVersionsGetInstanceFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetInstanceFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => PreReleaseVersionsGetInstanceFieldsPreReleaseVersion.App,
                "builds" => PreReleaseVersionsGetInstanceFieldsPreReleaseVersion.Builds,
                "platform" => PreReleaseVersionsGetInstanceFieldsPreReleaseVersion.Platform,
                "version" => PreReleaseVersionsGetInstanceFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}