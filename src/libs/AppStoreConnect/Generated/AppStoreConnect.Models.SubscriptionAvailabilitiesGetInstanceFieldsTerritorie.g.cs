
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAvailabilitiesGetInstanceFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAvailabilitiesGetInstanceFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilitiesGetInstanceFieldsTerritorie value)
        {
            return value switch
            {
                SubscriptionAvailabilitiesGetInstanceFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilitiesGetInstanceFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => SubscriptionAvailabilitiesGetInstanceFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}