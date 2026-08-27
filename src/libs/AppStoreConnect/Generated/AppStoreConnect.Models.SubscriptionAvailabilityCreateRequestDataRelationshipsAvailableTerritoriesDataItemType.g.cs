
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType value)
        {
            return value switch
            {
                SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionAvailabilityCreateRequestDataRelationshipsAvailableTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}