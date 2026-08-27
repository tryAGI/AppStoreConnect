
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsBuildIcon
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
    public static class CiProductsAppGetToOneRelatedFieldsBuildIconExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsBuildIcon value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsBuildIcon.IconAsset => "iconAsset",
                CiProductsAppGetToOneRelatedFieldsBuildIcon.IconType => "iconType",
                CiProductsAppGetToOneRelatedFieldsBuildIcon.Masked => "masked",
                CiProductsAppGetToOneRelatedFieldsBuildIcon.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsBuildIcon? ToEnum(string value)
        {
            return value switch
            {
                "iconAsset" => CiProductsAppGetToOneRelatedFieldsBuildIcon.IconAsset,
                "iconType" => CiProductsAppGetToOneRelatedFieldsBuildIcon.IconType,
                "masked" => CiProductsAppGetToOneRelatedFieldsBuildIcon.Masked,
                "name" => CiProductsAppGetToOneRelatedFieldsBuildIcon.Name,
                _ => null,
            };
        }
    }
}