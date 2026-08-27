
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildUploadRelationshipsAssetSpiFileDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildUploadFiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildUploadRelationshipsAssetSpiFileDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildUploadRelationshipsAssetSpiFileDataType value)
        {
            return value switch
            {
                BuildUploadRelationshipsAssetSpiFileDataType.BuildUploadFiles => "buildUploadFiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildUploadRelationshipsAssetSpiFileDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildUploadFiles" => BuildUploadRelationshipsAssetSpiFileDataType.BuildUploadFiles,
                _ => null,
            };
        }
    }
}