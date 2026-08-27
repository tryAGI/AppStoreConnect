
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor
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
    public static class InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.ActorType => "actorType",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.ApiKeyId => "apiKeyId",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.UserEmail => "userEmail",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.UserFirstName => "userFirstName",
                InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.ActorType,
                "apiKeyId" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.ApiKeyId,
                "userEmail" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.UserEmail,
                "userFirstName" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.UserFirstName,
                "userLastName" => InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}