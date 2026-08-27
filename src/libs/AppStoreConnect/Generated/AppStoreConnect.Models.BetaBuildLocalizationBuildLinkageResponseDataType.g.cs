
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaBuildLocalizationBuildLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBuildLocalizationBuildLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationBuildLinkageResponseDataType value)
        {
            return value switch
            {
                BetaBuildLocalizationBuildLinkageResponseDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationBuildLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaBuildLocalizationBuildLinkageResponseDataType.Builds,
                _ => null,
            };
        }
    }
}