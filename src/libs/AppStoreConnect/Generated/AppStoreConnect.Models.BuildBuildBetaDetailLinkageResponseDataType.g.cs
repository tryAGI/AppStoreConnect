
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBuildBetaDetailLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildBetaDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBuildBetaDetailLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBuildBetaDetailLinkageResponseDataType value)
        {
            return value switch
            {
                BuildBuildBetaDetailLinkageResponseDataType.BuildBetaDetails => "buildBetaDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBuildBetaDetailLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildBetaDetails" => BuildBuildBetaDetailLinkageResponseDataType.BuildBetaDetails,
                _ => null,
            };
        }
    }
}