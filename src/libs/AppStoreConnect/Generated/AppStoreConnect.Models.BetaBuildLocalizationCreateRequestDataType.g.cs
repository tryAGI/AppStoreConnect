
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBuildLocalizationCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaBuildLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBuildLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                BetaBuildLocalizationCreateRequestDataType.BetaBuildLocalizations => "betaBuildLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaBuildLocalizations" => BetaBuildLocalizationCreateRequestDataType.BetaBuildLocalizations,
                _ => null,
            };
        }
    }
}