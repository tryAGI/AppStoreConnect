
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem
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
    public static class InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem.CreatedByActor => "createdByActor",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem.DeactivatedByActor => "deactivatedByActor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "createdByActor" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem.CreatedByActor,
                "deactivatedByActor" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem.DeactivatedByActor,
                _ => null,
            };
        }
    }
}