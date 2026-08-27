
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeCreateRequestDataRelationshipsInAppPurchaseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeCreateRequestDataRelationshipsInAppPurchaseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCreateRequestDataRelationshipsInAppPurchaseDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCreateRequestDataRelationshipsInAppPurchaseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseOfferCodeCreateRequestDataRelationshipsInAppPurchaseDataType.InAppPurchases,
                _ => null,
            };
        }
    }
}