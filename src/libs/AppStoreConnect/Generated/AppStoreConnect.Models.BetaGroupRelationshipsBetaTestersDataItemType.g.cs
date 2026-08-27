
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupRelationshipsBetaTestersDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupRelationshipsBetaTestersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupRelationshipsBetaTestersDataItemType value)
        {
            return value switch
            {
                BetaGroupRelationshipsBetaTestersDataItemType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupRelationshipsBetaTestersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaGroupRelationshipsBetaTestersDataItemType.BetaTesters,
                _ => null,
            };
        }
    }
}