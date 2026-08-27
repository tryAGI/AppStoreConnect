
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildRelationshipsBetaGroupsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsBetaGroupsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsBetaGroupsDataItemType value)
        {
            return value switch
            {
                BuildRelationshipsBetaGroupsDataItemType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsBetaGroupsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => BuildRelationshipsBetaGroupsDataItemType.BetaGroups,
                _ => null,
            };
        }
    }
}