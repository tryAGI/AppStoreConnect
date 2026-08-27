
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedByActor,
        /// <summary>
        /// 
        /// </summary>
        DeactivatedByActor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceIncludeItem.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceIncludeItem.DeactivatedByActor => "deactivatedByActor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "createdByActor" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceIncludeItem.CreatedByActor,
                "deactivatedByActor" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceIncludeItem.DeactivatedByActor,
                _ => null,
            };
        }
    }
}