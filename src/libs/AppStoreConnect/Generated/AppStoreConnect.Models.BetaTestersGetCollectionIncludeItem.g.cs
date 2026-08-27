
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTestersGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTestersGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetCollectionIncludeItem value)
        {
            return value switch
            {
                BetaTestersGetCollectionIncludeItem.Apps => "apps",
                BetaTestersGetCollectionIncludeItem.BetaGroups => "betaGroups",
                BetaTestersGetCollectionIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaTestersGetCollectionIncludeItem.Apps,
                "betaGroups" => BetaTestersGetCollectionIncludeItem.BetaGroups,
                "builds" => BetaTestersGetCollectionIncludeItem.Builds,
                _ => null,
            };
        }
    }
}