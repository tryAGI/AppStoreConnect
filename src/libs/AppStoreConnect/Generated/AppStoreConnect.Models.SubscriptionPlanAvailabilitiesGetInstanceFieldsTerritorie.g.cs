
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilitiesGetInstanceFieldsTerritorie
    {
        /// <summary>
        ///
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilitiesGetInstanceFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilitiesGetInstanceFieldsTerritorie value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilitiesGetInstanceFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilitiesGetInstanceFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => SubscriptionPlanAvailabilitiesGetInstanceFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}