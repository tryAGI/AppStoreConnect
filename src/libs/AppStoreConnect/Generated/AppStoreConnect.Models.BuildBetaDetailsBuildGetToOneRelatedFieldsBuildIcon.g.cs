
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon
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
    public static class BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon value)
        {
            return value switch
            {
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon.IconAsset => "iconAsset",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon.IconType => "iconType",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon.Masked => "masked",
                BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon? ToEnum(string value)
        {
            return value switch
            {
                "iconAsset" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon.IconAsset,
                "iconType" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon.IconType,
                "masked" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon.Masked,
                "name" => BuildBetaDetailsBuildGetToOneRelatedFieldsBuildIcon.Name,
                _ => null,
            };
        }
    }
}