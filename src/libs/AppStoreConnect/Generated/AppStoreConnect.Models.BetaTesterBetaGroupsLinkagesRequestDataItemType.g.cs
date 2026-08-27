
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTesterBetaGroupsLinkagesRequestDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterBetaGroupsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterBetaGroupsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                BetaTesterBetaGroupsLinkagesRequestDataItemType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterBetaGroupsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => BetaTesterBetaGroupsLinkagesRequestDataItemType.BetaGroups,
                _ => null,
            };
        }
    }
}