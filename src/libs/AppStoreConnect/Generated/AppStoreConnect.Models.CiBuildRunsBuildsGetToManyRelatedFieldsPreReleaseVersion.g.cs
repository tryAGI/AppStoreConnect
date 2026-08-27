
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion
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
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion.App => "app",
                CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion.Builds => "builds",
                CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion.Platform => "platform",
                CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion.App,
                "builds" => CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion.Builds,
                "platform" => CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion.Platform,
                "version" => CiBuildRunsBuildsGetToManyRelatedFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}