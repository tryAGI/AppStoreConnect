
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTesterBetaGroupsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterBetaGroupsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterBetaGroupsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BetaTesterBetaGroupsLinkagesResponseDataItemType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterBetaGroupsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => BetaTesterBetaGroupsLinkagesResponseDataItemType.BetaGroups,
                _ => null,
            };
        }
    }
}