
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsIconsGetToManyRelatedFieldsBuildIcon
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
    public static class BuildsIconsGetToManyRelatedFieldsBuildIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsIconsGetToManyRelatedFieldsBuildIcon value)
        {
            return value switch
            {
                BuildsIconsGetToManyRelatedFieldsBuildIcon.IconAsset => "iconAsset",
                BuildsIconsGetToManyRelatedFieldsBuildIcon.IconType => "iconType",
                BuildsIconsGetToManyRelatedFieldsBuildIcon.Masked => "masked",
                BuildsIconsGetToManyRelatedFieldsBuildIcon.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsIconsGetToManyRelatedFieldsBuildIcon? ToEnum(string value)
        {
            return value switch
            {
                "iconAsset" => BuildsIconsGetToManyRelatedFieldsBuildIcon.IconAsset,
                "iconType" => BuildsIconsGetToManyRelatedFieldsBuildIcon.IconType,
                "masked" => BuildsIconsGetToManyRelatedFieldsBuildIcon.Masked,
                "name" => BuildsIconsGetToManyRelatedFieldsBuildIcon.Name,
                _ => null,
            };
        }
    }
}