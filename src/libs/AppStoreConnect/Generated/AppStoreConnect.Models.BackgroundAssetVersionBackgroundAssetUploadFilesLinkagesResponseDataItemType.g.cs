
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionBackgroundAssetUploadFilesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionBackgroundAssetUploadFilesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionBackgroundAssetUploadFilesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BackgroundAssetVersionBackgroundAssetUploadFilesLinkagesResponseDataItemType.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionBackgroundAssetUploadFilesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetUploadFiles" => BackgroundAssetVersionBackgroundAssetUploadFilesLinkagesResponseDataItemType.BackgroundAssetUploadFiles,
                _ => null,
            };
        }
    }
}