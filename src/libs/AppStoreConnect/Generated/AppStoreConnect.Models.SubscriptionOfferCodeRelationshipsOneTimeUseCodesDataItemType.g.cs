
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionOfferCodeOneTimeUseCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType value)
        {
            return value switch
            {
                SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType.SubscriptionOfferCodeOneTimeUseCodes => "subscriptionOfferCodeOneTimeUseCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionOfferCodeOneTimeUseCodes" => SubscriptionOfferCodeRelationshipsOneTimeUseCodesDataItemType.SubscriptionOfferCodeOneTimeUseCodes,
                _ => null,
            };
        }
    }
}