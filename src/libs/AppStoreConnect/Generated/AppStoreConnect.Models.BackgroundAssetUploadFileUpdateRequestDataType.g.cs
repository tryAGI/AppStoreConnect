
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetUploadFileUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetUploadFileUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetUploadFileUpdateRequestDataType value)
        {
            return value switch
            {
                BackgroundAssetUploadFileUpdateRequestDataType.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetUploadFileUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetUploadFiles" => BackgroundAssetUploadFileUpdateRequestDataType.BackgroundAssetUploadFiles,
                _ => null,
            };
        }
    }
}