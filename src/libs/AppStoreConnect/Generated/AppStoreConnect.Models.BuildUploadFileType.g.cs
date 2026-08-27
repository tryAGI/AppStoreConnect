
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadFileType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFileType value)
        {
            return value switch
            {
                BuildUploadFileType.BuildUploadFiles => "buildUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFileType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploadFiles" => BuildUploadFileType.BuildUploadFiles,
                _ => null,
            };
        }
    }
}