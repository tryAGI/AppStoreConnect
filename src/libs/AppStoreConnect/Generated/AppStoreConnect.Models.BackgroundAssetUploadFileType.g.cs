
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetUploadFileType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetUploadFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetUploadFileType value)
        {
            return value switch
            {
                BackgroundAssetUploadFileType.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetUploadFileType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetUploadFiles" => BackgroundAssetUploadFileType.BackgroundAssetUploadFiles,
                _ => null,
            };
        }
    }
}