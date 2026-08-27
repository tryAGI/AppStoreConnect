
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsBetaGroupsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsBetaGroupsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsBetaGroupsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsBetaGroupsDataItemType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsBetaGroupsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => AppRelationshipsBetaGroupsDataItemType.BetaGroups,
                _ => null,
            };
        }
    }
}