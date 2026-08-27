
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaDetailType
    {
        /// <summary>
        ///
        /// </summary>
        BuildBetaDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaDetailType value)
        {
            return value switch
            {
                BuildBetaDetailType.BuildBetaDetails => "buildBetaDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaDetailType? ToEnum(string value)
        {
            return value switch
            {
                "buildBetaDetails" => BuildBetaDetailType.BuildBetaDetails,
                _ => null,
            };
        }
    }
}