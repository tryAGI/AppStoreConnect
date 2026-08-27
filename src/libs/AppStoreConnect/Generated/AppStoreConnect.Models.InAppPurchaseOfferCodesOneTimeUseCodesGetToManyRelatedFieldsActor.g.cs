
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor
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
    public static class InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor value)
        {
            return value switch
            {
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.ActorType => "actorType",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.ApiKeyId => "apiKeyId",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.UserEmail => "userEmail",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.UserFirstName => "userFirstName",
                InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.ActorType,
                "apiKeyId" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.ApiKeyId,
                "userEmail" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.UserEmail,
                "userFirstName" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.UserFirstName,
                "userLastName" => InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}