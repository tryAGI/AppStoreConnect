
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTesterRelationshipsBetaGroupsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterRelationshipsBetaGroupsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterRelationshipsBetaGroupsDataItemType value)
        {
            return value switch
            {
                BetaTesterRelationshipsBetaGroupsDataItemType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterRelationshipsBetaGroupsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => BetaTesterRelationshipsBetaGroupsDataItemType.BetaGroups,
                _ => null,
            };
        }
    }
}