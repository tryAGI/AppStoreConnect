
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsBuildIcon
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
    public static class AppsGetCollectionFieldsBuildIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsBuildIcon value)
        {
            return value switch
            {
                AppsGetCollectionFieldsBuildIcon.IconAsset => "iconAsset",
                AppsGetCollectionFieldsBuildIcon.IconType => "iconType",
                AppsGetCollectionFieldsBuildIcon.Masked => "masked",
                AppsGetCollectionFieldsBuildIcon.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsBuildIcon? ToEnum(string value)
        {
            return value switch
            {
                "iconAsset" => AppsGetCollectionFieldsBuildIcon.IconAsset,
                "iconType" => AppsGetCollectionFieldsBuildIcon.IconType,
                "masked" => AppsGetCollectionFieldsBuildIcon.Masked,
                "name" => AppsGetCollectionFieldsBuildIcon.Name,
                _ => null,
            };
        }
    }
}