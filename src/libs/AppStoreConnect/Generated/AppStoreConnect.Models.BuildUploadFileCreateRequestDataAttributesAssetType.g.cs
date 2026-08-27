
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadFileCreateRequestDataAttributesAssetType
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
    public static class BuildUploadFileCreateRequestDataAttributesAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFileCreateRequestDataAttributesAssetType value)
        {
            return value switch
            {
                BuildUploadFileCreateRequestDataAttributesAssetType.Asset => "ASSET",
                BuildUploadFileCreateRequestDataAttributesAssetType.AssetDescription => "ASSET_DESCRIPTION",
                BuildUploadFileCreateRequestDataAttributesAssetType.AssetSpi => "ASSET_SPI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFileCreateRequestDataAttributesAssetType? ToEnum(string value)
        {
            return value switch
            {
                "ASSET" => BuildUploadFileCreateRequestDataAttributesAssetType.Asset,
                "ASSET_DESCRIPTION" => BuildUploadFileCreateRequestDataAttributesAssetType.AssetDescription,
                "ASSET_SPI" => BuildUploadFileCreateRequestDataAttributesAssetType.AssetSpi,
                _ => null,
            };
        }
    }
}