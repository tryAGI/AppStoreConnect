
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsReviewSubmissionsGetToManyRelatedFieldsActor
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
    public static class AppsReviewSubmissionsGetToManyRelatedFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsReviewSubmissionsGetToManyRelatedFieldsActor value)
        {
            return value switch
            {
                AppsReviewSubmissionsGetToManyRelatedFieldsActor.ActorType => "actorType",
                AppsReviewSubmissionsGetToManyRelatedFieldsActor.ApiKeyId => "apiKeyId",
                AppsReviewSubmissionsGetToManyRelatedFieldsActor.UserEmail => "userEmail",
                AppsReviewSubmissionsGetToManyRelatedFieldsActor.UserFirstName => "userFirstName",
                AppsReviewSubmissionsGetToManyRelatedFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsReviewSubmissionsGetToManyRelatedFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => AppsReviewSubmissionsGetToManyRelatedFieldsActor.ActorType,
                "apiKeyId" => AppsReviewSubmissionsGetToManyRelatedFieldsActor.ApiKeyId,
                "userEmail" => AppsReviewSubmissionsGetToManyRelatedFieldsActor.UserEmail,
                "userFirstName" => AppsReviewSubmissionsGetToManyRelatedFieldsActor.UserFirstName,
                "userLastName" => AppsReviewSubmissionsGetToManyRelatedFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}