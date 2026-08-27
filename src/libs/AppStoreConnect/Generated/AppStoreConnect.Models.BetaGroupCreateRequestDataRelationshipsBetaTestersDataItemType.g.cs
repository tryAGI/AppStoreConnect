
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupCreateRequestDataRelationshipsBetaTestersDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupCreateRequestDataRelationshipsBetaTestersDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupCreateRequestDataRelationshipsBetaTestersDataItemType value)
        {
            return value switch
            {
                BetaGroupCreateRequestDataRelationshipsBetaTestersDataItemType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupCreateRequestDataRelationshipsBetaTestersDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaGroupCreateRequestDataRelationshipsBetaTestersDataItemType.BetaTesters,
                _ => null,
            };
        }
    }
}