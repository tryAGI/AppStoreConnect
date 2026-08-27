
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsBuildIcon
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
    public static class AppsGetInstanceFieldsBuildIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsBuildIcon value)
        {
            return value switch
            {
                AppsGetInstanceFieldsBuildIcon.IconAsset => "iconAsset",
                AppsGetInstanceFieldsBuildIcon.IconType => "iconType",
                AppsGetInstanceFieldsBuildIcon.Masked => "masked",
                AppsGetInstanceFieldsBuildIcon.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsBuildIcon? ToEnum(string value)
        {
            return value switch
            {
                "iconAsset" => AppsGetInstanceFieldsBuildIcon.IconAsset,
                "iconType" => AppsGetInstanceFieldsBuildIcon.IconType,
                "masked" => AppsGetInstanceFieldsBuildIcon.Masked,
                "name" => AppsGetInstanceFieldsBuildIcon.Name,
                _ => null,
            };
        }
    }
}