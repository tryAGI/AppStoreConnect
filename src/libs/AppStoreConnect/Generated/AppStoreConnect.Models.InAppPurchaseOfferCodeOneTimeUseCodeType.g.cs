
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodeType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseOfferCodeOneTimeUseCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodeType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodeType.InAppPurchaseOfferCodeOneTimeUseCodes => "inAppPurchaseOfferCodeOneTimeUseCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodeType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeOneTimeUseCodes" => InAppPurchaseOfferCodeOneTimeUseCodeType.InAppPurchaseOfferCodeOneTimeUseCodes,
                _ => null,
            };
        }
    }
}