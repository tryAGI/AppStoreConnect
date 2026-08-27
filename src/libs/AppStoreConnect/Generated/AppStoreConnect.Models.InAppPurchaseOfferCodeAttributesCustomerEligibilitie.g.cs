
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeAttributesCustomerEligibilitie
    {
        /// <summary>
        /// 
        /// </summary>
        ActiveSpender,
        /// <summary>
        /// 
        /// </summary>
        ChurnedSpender,
        /// <summary>
        /// 
        /// </summary>
        NonSpender,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeAttributesCustomerEligibilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeAttributesCustomerEligibilitie value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeAttributesCustomerEligibilitie.ActiveSpender => "ACTIVE_SPENDER",
                InAppPurchaseOfferCodeAttributesCustomerEligibilitie.ChurnedSpender => "CHURNED_SPENDER",
                InAppPurchaseOfferCodeAttributesCustomerEligibilitie.NonSpender => "NON_SPENDER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeAttributesCustomerEligibilitie? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_SPENDER" => InAppPurchaseOfferCodeAttributesCustomerEligibilitie.ActiveSpender,
                "CHURNED_SPENDER" => InAppPurchaseOfferCodeAttributesCustomerEligibilitie.ChurnedSpender,
                "NON_SPENDER" => InAppPurchaseOfferCodeAttributesCustomerEligibilitie.NonSpender,
                _ => null,
            };
        }
    }
}