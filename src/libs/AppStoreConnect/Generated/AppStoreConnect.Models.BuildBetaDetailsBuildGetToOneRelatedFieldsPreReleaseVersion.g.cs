
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion.App => "app",
                BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion.Builds => "builds",
                BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion.Platform => "platform",
                BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion.App,
                "builds" => BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion.Builds,
                "platform" => BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion.Platform,
                "version" => BuildBetaDetailsBuildGetToOneRelatedFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}