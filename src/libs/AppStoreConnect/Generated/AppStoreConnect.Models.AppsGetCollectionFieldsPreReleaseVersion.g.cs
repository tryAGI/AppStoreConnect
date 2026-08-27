
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsPreReleaseVersion
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
    public static class AppsGetCollectionFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsPreReleaseVersion value)
        {
            return value switch
            {
                AppsGetCollectionFieldsPreReleaseVersion.App => "app",
                AppsGetCollectionFieldsPreReleaseVersion.Builds => "builds",
                AppsGetCollectionFieldsPreReleaseVersion.Platform => "platform",
                AppsGetCollectionFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsPreReleaseVersion.App,
                "builds" => AppsGetCollectionFieldsPreReleaseVersion.Builds,
                "platform" => AppsGetCollectionFieldsPreReleaseVersion.Platform,
                "version" => AppsGetCollectionFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}