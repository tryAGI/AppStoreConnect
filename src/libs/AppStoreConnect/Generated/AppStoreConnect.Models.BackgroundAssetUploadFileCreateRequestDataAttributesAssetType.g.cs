
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetUploadFileCreateRequestDataAttributesAssetType
    {
        /// <summary>
        ///
        /// </summary>
        Asset,
        /// <summary>
        ///
        /// </summary>
        Manifest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetUploadFileCreateRequestDataAttributesAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetUploadFileCreateRequestDataAttributesAssetType value)
        {
            return value switch
            {
                BackgroundAssetUploadFileCreateRequestDataAttributesAssetType.Asset => "ASSET",
                BackgroundAssetUploadFileCreateRequestDataAttributesAssetType.Manifest => "MANIFEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetUploadFileCreateRequestDataAttributesAssetType? ToEnum(string value)
        {
            return value switch
            {
                "ASSET" => BackgroundAssetUploadFileCreateRequestDataAttributesAssetType.Asset,
                "MANIFEST" => BackgroundAssetUploadFileCreateRequestDataAttributesAssetType.Manifest,
                _ => null,
            };
        }
    }
}