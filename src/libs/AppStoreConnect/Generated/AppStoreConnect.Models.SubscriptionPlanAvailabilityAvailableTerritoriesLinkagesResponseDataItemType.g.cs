
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesResponseDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesResponseDataItemType.Territories,
                _ => null,
            };
        }
    }
}