
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupBetaTestersLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupBetaTestersLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupBetaTestersLinkagesRequestDataItemType value)
        {
            return value switch
            {
                BetaGroupBetaTestersLinkagesRequestDataItemType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupBetaTestersLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaGroupBetaTestersLinkagesRequestDataItemType.BetaTesters,
                _ => null,
            };
        }
    }
}