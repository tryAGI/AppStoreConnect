
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadRelationshipsBuildDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadRelationshipsBuildDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadRelationshipsBuildDataType value)
        {
            return value switch
            {
                BuildUploadRelationshipsBuildDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadRelationshipsBuildDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BuildUploadRelationshipsBuildDataType.Builds,
                _ => null,
            };
        }
    }
}