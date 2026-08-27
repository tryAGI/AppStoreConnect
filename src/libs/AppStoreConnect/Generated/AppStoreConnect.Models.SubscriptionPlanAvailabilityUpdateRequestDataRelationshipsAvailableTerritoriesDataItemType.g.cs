
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilityUpdateRequestDataRelationshipsAvailableTerritoriesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilityUpdateRequestDataRelationshipsAvailableTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilityUpdateRequestDataRelationshipsAvailableTerritoriesDataItemType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilityUpdateRequestDataRelationshipsAvailableTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilityUpdateRequestDataRelationshipsAvailableTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionPlanAvailabilityUpdateRequestDataRelationshipsAvailableTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}