
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetUploadFileAttributesAssetType
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
    public static class BackgroundAssetUploadFileAttributesAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetUploadFileAttributesAssetType value)
        {
            return value switch
            {
                BackgroundAssetUploadFileAttributesAssetType.Asset => "ASSET",
                BackgroundAssetUploadFileAttributesAssetType.Manifest => "MANIFEST",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetUploadFileAttributesAssetType? ToEnum(string value)
        {
            return value switch
            {
                "ASSET" => BackgroundAssetUploadFileAttributesAssetType.Asset,
                "MANIFEST" => BackgroundAssetUploadFileAttributesAssetType.Manifest,
                _ => null,
            };
        }
    }
}