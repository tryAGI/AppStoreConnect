
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodeValueType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseOfferCodeOneTimeUseCodeValues,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodeValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodeValueType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodeValueType.InAppPurchaseOfferCodeOneTimeUseCodeValues => "inAppPurchaseOfferCodeOneTimeUseCodeValues",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodeValueType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeOneTimeUseCodeValues" => InAppPurchaseOfferCodeOneTimeUseCodeValueType.InAppPurchaseOfferCodeOneTimeUseCodeValues,
                _ => null,
            };
        }
    }
}