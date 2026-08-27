
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem
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
    public static class InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem.DeactivatedByActor => "deactivatedByActor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "createdByActor" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem.CreatedByActor,
                "deactivatedByActor" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem.DeactivatedByActor,
                _ => null,
            };
        }
    }
}