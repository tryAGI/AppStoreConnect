
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionAvailabilitiesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AvailableTerritories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAvailabilitiesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilitiesGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionAvailabilitiesGetInstanceIncludeItem.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilitiesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "availableTerritories" => SubscriptionAvailabilitiesGetInstanceIncludeItem.AvailableTerritories,
                _ => null,
            };
        }
    }
}