
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BuildBetaDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaDetailUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailUpdateRequestDataType value)
        {
            return value switch
            {
                BuildBetaDetailUpdateRequestDataType.BuildBetaDetails => "buildBetaDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildBetaDetails" => BuildBetaDetailUpdateRequestDataType.BuildBetaDetails,
                _ => null,
            };
        }
    }
}