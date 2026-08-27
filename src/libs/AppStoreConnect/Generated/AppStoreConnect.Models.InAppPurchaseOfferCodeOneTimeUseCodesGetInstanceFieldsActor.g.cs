
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor
    {
        /// <summary>
        /// 
        /// </summary>
        ActorType,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        UserEmail,
        /// <summary>
        /// 
        /// </summary>
        UserFirstName,
        /// <summary>
        /// 
        /// </summary>
        UserLastName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.ActorType => "actorType",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.ApiKeyId => "apiKeyId",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.UserEmail => "userEmail",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.UserFirstName => "userFirstName",
                InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.ActorType,
                "apiKeyId" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.ApiKeyId,
                "userEmail" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.UserEmail,
                "userFirstName" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.UserFirstName,
                "userLastName" => InAppPurchaseOfferCodeOneTimeUseCodesGetInstanceFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}