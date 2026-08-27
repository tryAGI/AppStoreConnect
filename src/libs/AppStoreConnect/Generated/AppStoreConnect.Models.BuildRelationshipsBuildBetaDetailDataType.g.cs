
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildRelationshipsBuildBetaDetailDataType
    {
        /// <summary>
        ///
        /// </summary>
        BuildBetaDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsBuildBetaDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsBuildBetaDetailDataType value)
        {
            return value switch
            {
                BuildRelationshipsBuildBetaDetailDataType.BuildBetaDetails => "buildBetaDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsBuildBetaDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildBetaDetails" => BuildRelationshipsBuildBetaDetailDataType.BuildBetaDetails,
                _ => null,
            };
        }
    }
}