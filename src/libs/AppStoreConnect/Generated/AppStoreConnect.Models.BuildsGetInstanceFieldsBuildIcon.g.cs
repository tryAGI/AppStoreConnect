
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetInstanceFieldsBuildIcon
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
    public static class BuildsGetInstanceFieldsBuildIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetInstanceFieldsBuildIcon value)
        {
            return value switch
            {
                BuildsGetInstanceFieldsBuildIcon.IconAsset => "iconAsset",
                BuildsGetInstanceFieldsBuildIcon.IconType => "iconType",
                BuildsGetInstanceFieldsBuildIcon.Masked => "masked",
                BuildsGetInstanceFieldsBuildIcon.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetInstanceFieldsBuildIcon? ToEnum(string value)
        {
            return value switch
            {
                "iconAsset" => BuildsGetInstanceFieldsBuildIcon.IconAsset,
                "iconType" => BuildsGetInstanceFieldsBuildIcon.IconType,
                "masked" => BuildsGetInstanceFieldsBuildIcon.Masked,
                "name" => BuildsGetInstanceFieldsBuildIcon.Name,
                _ => null,
            };
        }
    }
}