
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem
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
    public static class InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem.DeactivatedByActor => "deactivatedByActor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "createdByActor" => InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem.CreatedByActor,
                "deactivatedByActor" => InAppPurchaseOfferCodeCustomCodesGetInstanceIncludeItem.DeactivatedByActor,
                _ => null,
            };
        }
    }
}