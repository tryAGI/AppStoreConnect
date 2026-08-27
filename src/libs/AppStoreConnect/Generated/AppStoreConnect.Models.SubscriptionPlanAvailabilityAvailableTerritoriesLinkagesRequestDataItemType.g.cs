
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesRequestDataItemType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesRequestDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionPlanAvailabilityAvailableTerritoriesLinkagesRequestDataItemType.Territories,
                _ => null,
            };
        }
    }
}