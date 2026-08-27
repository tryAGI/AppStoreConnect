
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PreReleaseVersionsGetCollectionFieldsPreReleaseVersion
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
    public static class PreReleaseVersionsGetCollectionFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetCollectionFieldsPreReleaseVersion value)
        {
            return value switch
            {
                PreReleaseVersionsGetCollectionFieldsPreReleaseVersion.App => "app",
                PreReleaseVersionsGetCollectionFieldsPreReleaseVersion.Builds => "builds",
                PreReleaseVersionsGetCollectionFieldsPreReleaseVersion.Platform => "platform",
                PreReleaseVersionsGetCollectionFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetCollectionFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => PreReleaseVersionsGetCollectionFieldsPreReleaseVersion.App,
                "builds" => PreReleaseVersionsGetCollectionFieldsPreReleaseVersion.Builds,
                "platform" => PreReleaseVersionsGetCollectionFieldsPreReleaseVersion.Platform,
                "version" => PreReleaseVersionsGetCollectionFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}