
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBetaGroupsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaGroupsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaGroupsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                BuildBetaGroupsLinkagesRequestDataItemType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaGroupsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => BuildBetaGroupsLinkagesRequestDataItemType.BetaGroups,
                _ => null,
            };
        }
    }
}