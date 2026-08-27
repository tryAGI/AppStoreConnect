
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion
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
    public static class AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion value)
        {
            return value switch
            {
                AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion.App => "app",
                AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion.Builds => "builds",
                AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion.Platform => "platform",
                AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion.App,
                "builds" => AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion.Builds,
                "platform" => AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion.Platform,
                "version" => AppsPreReleaseVersionsGetToManyRelatedFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}