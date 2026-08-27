
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType.InAppPurchaseOfferCodes => "inAppPurchaseOfferCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodes" => InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCodeDataType.InAppPurchaseOfferCodes,
                _ => null,
            };
        }
    }
}