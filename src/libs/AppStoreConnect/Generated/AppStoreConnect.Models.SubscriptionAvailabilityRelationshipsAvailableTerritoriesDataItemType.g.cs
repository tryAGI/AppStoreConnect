
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType value)
        {
            return value switch
            {
                SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionAvailabilityRelationshipsAvailableTerritoriesDataItemType.Territories,
                _ => null,
            };
        }
    }
}