
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploads,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadType value)
        {
            return value switch
            {
                BuildUploadType.BuildUploads => "buildUploads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploads" => BuildUploadType.BuildUploads,
                _ => null,
            };
        }
    }
}