
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildRelationshipsBuildUploadDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildUploads,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsBuildUploadDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsBuildUploadDataType value)
        {
            return value switch
            {
                BuildRelationshipsBuildUploadDataType.BuildUploads => "buildUploads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsBuildUploadDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploads" => BuildRelationshipsBuildUploadDataType.BuildUploads,
                _ => null,
            };
        }
    }
}