
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploads,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType value)
        {
            return value switch
            {
                BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType.BuildUploads => "buildUploads",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploads" => BuildUploadFileCreateRequestDataRelationshipsBuildUploadDataType.BuildUploads,
                _ => null,
            };
        }
    }
}