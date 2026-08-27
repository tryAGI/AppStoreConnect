
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum KidsAgeBand
    {
        /// <summary>
        ///
        /// </summary>
        FiveAndUnder,
        /// <summary>
        ///
        /// </summary>
        NineToEleven,
        /// <summary>
        ///
        /// </summary>
        SixToEight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KidsAgeBandExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KidsAgeBand value)
        {
            return value switch
            {
                KidsAgeBand.FiveAndUnder => "FIVE_AND_UNDER",
                KidsAgeBand.NineToEleven => "NINE_TO_ELEVEN",
                KidsAgeBand.SixToEight => "SIX_TO_EIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KidsAgeBand? ToEnum(string value)
        {
            return value switch
            {
                "FIVE_AND_UNDER" => KidsAgeBand.FiveAndUnder,
                "NINE_TO_ELEVEN" => KidsAgeBand.NineToEleven,
                "SIX_TO_EIGHT" => KidsAgeBand.SixToEight,
                _ => null,
            };
        }
    }
}