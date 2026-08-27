
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPlanAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilitiesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType.SubscriptionPlanAvailabilities => "subscriptionPlanAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPlanAvailabilities" => SubscriptionPlanAvailabilitiesLinkagesResponseDataItemType.SubscriptionPlanAvailabilities,
                _ => null,
            };
        }
    }
}