
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionRelationshipsManifestFileDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionRelationshipsManifestFileDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionRelationshipsManifestFileDataType value)
        {
            return value switch
            {
                BackgroundAssetVersionRelationshipsManifestFileDataType.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionRelationshipsManifestFileDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetUploadFiles" => BackgroundAssetVersionRelationshipsManifestFileDataType.BackgroundAssetUploadFiles,
                _ => null,
            };
        }
    }
}