
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsPreReleaseVersion
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
    public static class CiProductsAppGetToOneRelatedFieldsPreReleaseVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsPreReleaseVersion value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsPreReleaseVersion.App => "app",
                CiProductsAppGetToOneRelatedFieldsPreReleaseVersion.Builds => "builds",
                CiProductsAppGetToOneRelatedFieldsPreReleaseVersion.Platform => "platform",
                CiProductsAppGetToOneRelatedFieldsPreReleaseVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsPreReleaseVersion? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsPreReleaseVersion.App,
                "builds" => CiProductsAppGetToOneRelatedFieldsPreReleaseVersion.Builds,
                "platform" => CiProductsAppGetToOneRelatedFieldsPreReleaseVersion.Platform,
                "version" => CiProductsAppGetToOneRelatedFieldsPreReleaseVersion.Version,
                _ => null,
            };
        }
    }
}