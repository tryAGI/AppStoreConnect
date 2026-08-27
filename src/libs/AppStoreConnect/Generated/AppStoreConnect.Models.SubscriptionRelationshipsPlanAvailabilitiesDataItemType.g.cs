
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionRelationshipsPlanAvailabilitiesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPlanAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsPlanAvailabilitiesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsPlanAvailabilitiesDataItemType value)
        {
            return value switch
            {
                SubscriptionRelationshipsPlanAvailabilitiesDataItemType.SubscriptionPlanAvailabilities => "subscriptionPlanAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsPlanAvailabilitiesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPlanAvailabilities" => SubscriptionRelationshipsPlanAvailabilitiesDataItemType.SubscriptionPlanAvailabilities,
                _ => null,
            };
        }
    }
}