
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon
    {
        /// <summary>
        ///
        /// </summary>
        IconAsset,
        /// <summary>
        ///
        /// </summary>
        IconType,
        /// <summary>
        ///
        /// </summary>
        Masked,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunsBuildsGetToManyRelatedFieldsBuildIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon.IconAsset => "iconAsset",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon.IconType => "iconType",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon.Masked => "masked",
                CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon? ToEnum(string value)
        {
            return value switch
            {
                "iconAsset" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon.IconAsset,
                "iconType" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon.IconType,
                "masked" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon.Masked,
                "name" => CiBuildRunsBuildsGetToManyRelatedFieldsBuildIcon.Name,
                _ => null,
            };
        }
    }
}