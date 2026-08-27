
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetCollectionFieldsPreReleaseVersion
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
    public static class BuildsGetCollectionFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsPreReleaseVersion value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsPreReleaseVersion.App => "app",
                BuildsGetCollectionFieldsPreReleaseVersion.Builds => "builds",
                BuildsGetCollectionFieldsPreReleaseVersion.Platform => "platform",
                BuildsGetCollectionFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsGetCollectionFieldsPreReleaseVersion.App,
                "builds" => BuildsGetCollectionFieldsPreReleaseVersion.Builds,
                "platform" => BuildsGetCollectionFieldsPreReleaseVersion.Platform,
                "version" => BuildsGetCollectionFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}