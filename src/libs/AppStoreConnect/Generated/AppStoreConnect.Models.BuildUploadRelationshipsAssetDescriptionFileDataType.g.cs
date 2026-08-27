
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildUploadRelationshipsAssetDescriptionFileDataType
    {
        /// <summary>
        ///
        /// </summary>
        BuildUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadRelationshipsAssetDescriptionFileDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadRelationshipsAssetDescriptionFileDataType value)
        {
            return value switch
            {
                BuildUploadRelationshipsAssetDescriptionFileDataType.BuildUploadFiles => "buildUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadRelationshipsAssetDescriptionFileDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploadFiles" => BuildUploadRelationshipsAssetDescriptionFileDataType.BuildUploadFiles,
                _ => null,
            };
        }
    }
}