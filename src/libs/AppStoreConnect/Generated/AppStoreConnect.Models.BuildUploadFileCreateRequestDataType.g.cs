
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadFileCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadFileCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFileCreateRequestDataType value)
        {
            return value switch
            {
                BuildUploadFileCreateRequestDataType.BuildUploadFiles => "buildUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFileCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploadFiles" => BuildUploadFileCreateRequestDataType.BuildUploadFiles,
                _ => null,
            };
        }
    }
}