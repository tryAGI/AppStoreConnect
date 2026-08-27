
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadRelationshipsAssetFileDataType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadRelationshipsAssetFileDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadRelationshipsAssetFileDataType value)
        {
            return value switch
            {
                BuildUploadRelationshipsAssetFileDataType.BuildUploadFiles => "buildUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadRelationshipsAssetFileDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploadFiles" => BuildUploadRelationshipsAssetFileDataType.BuildUploadFiles,
                _ => null,
            };
        }
    }
}