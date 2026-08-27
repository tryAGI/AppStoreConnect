
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPlanAvailabilitiesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AvailableTerritories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilitiesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilitiesGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilitiesGetInstanceIncludeItem.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilitiesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "availableTerritories" => SubscriptionPlanAvailabilitiesGetInstanceIncludeItem.AvailableTerritories,
                _ => null,
            };
        }
    }
}