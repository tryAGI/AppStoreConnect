
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaDetailBuildLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaDetailBuildLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailBuildLinkageResponseDataType value)
        {
            return value switch
            {
                BuildBetaDetailBuildLinkageResponseDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailBuildLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BuildBetaDetailBuildLinkageResponseDataType.Builds,
                _ => null,
            };
        }
    }
}