
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPlanAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionPlanAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}