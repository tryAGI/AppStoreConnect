
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadFileUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadFileUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFileUpdateRequestDataType value)
        {
            return value switch
            {
                BuildUploadFileUpdateRequestDataType.BuildUploadFiles => "buildUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFileUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploadFiles" => BuildUploadFileUpdateRequestDataType.BuildUploadFiles,
                _ => null,
            };
        }
    }
}