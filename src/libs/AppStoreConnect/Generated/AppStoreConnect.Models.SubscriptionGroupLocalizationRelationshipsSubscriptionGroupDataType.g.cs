
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => SubscriptionGroupLocalizationRelationshipsSubscriptionGroupDataType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}