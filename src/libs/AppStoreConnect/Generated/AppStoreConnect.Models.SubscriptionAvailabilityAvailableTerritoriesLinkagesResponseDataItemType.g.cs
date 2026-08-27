
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionAvailabilityAvailableTerritoriesLinkagesResponseDataItemType.Territories,
                _ => null,
            };
        }
    }
}