
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetUploadFileCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetUploadFileCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetUploadFileCreateRequestDataType value)
        {
            return value switch
            {
                BackgroundAssetUploadFileCreateRequestDataType.BackgroundAssetUploadFiles => "backgroundAssetUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetUploadFileCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "backgroundAssetUploadFiles" => BackgroundAssetUploadFileCreateRequestDataType.BackgroundAssetUploadFiles,
                _ => null,
            };
        }
    }
}