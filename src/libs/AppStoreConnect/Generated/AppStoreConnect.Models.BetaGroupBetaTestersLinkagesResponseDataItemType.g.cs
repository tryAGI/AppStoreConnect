
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupBetaTestersLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupBetaTestersLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupBetaTestersLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BetaGroupBetaTestersLinkagesResponseDataItemType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupBetaTestersLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaGroupBetaTestersLinkagesResponseDataItemType.BetaTesters,
                _ => null,
            };
        }
    }
}