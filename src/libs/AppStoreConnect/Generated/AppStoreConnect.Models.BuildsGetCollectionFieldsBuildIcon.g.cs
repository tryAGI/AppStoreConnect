
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsGetCollectionFieldsBuildIcon
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
    public static class BuildsGetCollectionFieldsBuildIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFieldsBuildIcon value)
        {
            return value switch
            {
                BuildsGetCollectionFieldsBuildIcon.IconAsset => "iconAsset",
                BuildsGetCollectionFieldsBuildIcon.IconType => "iconType",
                BuildsGetCollectionFieldsBuildIcon.Masked => "masked",
                BuildsGetCollectionFieldsBuildIcon.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFieldsBuildIcon? ToEnum(string value)
        {
            return value switch
            {
                "iconAsset" => BuildsGetCollectionFieldsBuildIcon.IconAsset,
                "iconType" => BuildsGetCollectionFieldsBuildIcon.IconType,
                "masked" => BuildsGetCollectionFieldsBuildIcon.Masked,
                "name" => BuildsGetCollectionFieldsBuildIcon.Name,
                _ => null,
            };
        }
    }
}