
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPricePointsGetInstanceFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPricePointsGetInstanceFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPricePointsGetInstanceFieldsTerritorie value)
        {
            return value switch
            {
                SubscriptionPricePointsGetInstanceFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPricePointsGetInstanceFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => SubscriptionPricePointsGetInstanceFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}