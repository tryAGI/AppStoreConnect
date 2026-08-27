
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploads,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadCreateRequestDataType value)
        {
            return value switch
            {
                BuildUploadCreateRequestDataType.BuildUploads => "buildUploads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploads" => BuildUploadCreateRequestDataType.BuildUploads,
                _ => null,
            };
        }
    }
}