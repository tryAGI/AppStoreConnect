
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodeUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseOfferCodeOneTimeUseCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodeUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodeUpdateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodeUpdateRequestDataType.InAppPurchaseOfferCodeOneTimeUseCodes => "inAppPurchaseOfferCodeOneTimeUseCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodeUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseOfferCodeOneTimeUseCodes" => InAppPurchaseOfferCodeOneTimeUseCodeUpdateRequestDataType.InAppPurchaseOfferCodeOneTimeUseCodes,
                _ => null,
            };
        }
    }
}