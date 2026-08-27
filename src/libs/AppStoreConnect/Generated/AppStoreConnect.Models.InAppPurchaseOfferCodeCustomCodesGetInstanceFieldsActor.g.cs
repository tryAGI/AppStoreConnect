
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor
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
    public static class InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.ActorType => "actorType",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.ApiKeyId => "apiKeyId",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.UserEmail => "userEmail",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.UserFirstName => "userFirstName",
                InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.ActorType,
                "apiKeyId" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.ApiKeyId,
                "userEmail" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.UserEmail,
                "userFirstName" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.UserFirstName,
                "userLastName" => InAppPurchaseOfferCodeCustomCodesGetInstanceFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}