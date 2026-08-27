
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadFileAttributesAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Asset,
        /// <summary>
        /// 
        /// </summary>
        AssetDescription,
        /// <summary>
        /// 
        /// </summary>
        AssetSpi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadFileAttributesAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFileAttributesAssetType value)
        {
            return value switch
            {
                BuildUploadFileAttributesAssetType.Asset => "ASSET",
                BuildUploadFileAttributesAssetType.AssetDescription => "ASSET_DESCRIPTION",
                BuildUploadFileAttributesAssetType.AssetSpi => "ASSET_SPI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFileAttributesAssetType? ToEnum(string value)
        {
            return value switch
            {
                "ASSET" => BuildUploadFileAttributesAssetType.Asset,
                "ASSET_DESCRIPTION" => BuildUploadFileAttributesAssetType.AssetDescription,
                "ASSET_SPI" => BuildUploadFileAttributesAssetType.AssetSpi,
                _ => null,
            };
        }
    }
}