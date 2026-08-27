
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodeValuesLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseOfferCodeOneTimeUseCodeValues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodeValuesLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodeValuesLinkageResponseDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodeValuesLinkageResponseDataType.InAppPurchaseOfferCodeOneTimeUseCodeValues => "inAppPurchaseOfferCodeOneTimeUseCodeValues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodeValuesLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeOneTimeUseCodeValues" => InAppPurchaseOfferCodeOneTimeUseCodeValuesLinkageResponseDataType.InAppPurchaseOfferCodeOneTimeUseCodeValues,
                _ => null,
            };
        }
    }
}