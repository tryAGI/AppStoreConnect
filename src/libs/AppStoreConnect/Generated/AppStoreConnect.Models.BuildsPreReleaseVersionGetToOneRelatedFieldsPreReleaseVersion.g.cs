
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion
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
    public static class BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion value)
        {
            return value switch
            {
                BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion.App => "app",
                BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion.Builds => "builds",
                BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion.Platform => "platform",
                BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion.App,
                "builds" => BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion.Builds,
                "platform" => BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion.Platform,
                "version" => BuildsPreReleaseVersionGetToOneRelatedFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}