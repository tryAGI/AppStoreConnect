
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie
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
    public static class InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie.ActiveSpender => "ACTIVE_SPENDER",
                InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie.ChurnedSpender => "CHURNED_SPENDER",
                InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie.NonSpender => "NON_SPENDER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE_SPENDER" => InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie.ActiveSpender,
                "CHURNED_SPENDER" => InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie.ChurnedSpender,
                "NON_SPENDER" => InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie.NonSpender,
                _ => null,
            };
        }
    }
}