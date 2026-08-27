
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBuildLocalizationUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaBuildLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBuildLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBuildLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                BetaBuildLocalizationUpdateRequestDataType.BetaBuildLocalizations => "betaBuildLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBuildLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaBuildLocalizations" => BetaBuildLocalizationUpdateRequestDataType.BetaBuildLocalizations,
                _ => null,
            };
        }
    }
}