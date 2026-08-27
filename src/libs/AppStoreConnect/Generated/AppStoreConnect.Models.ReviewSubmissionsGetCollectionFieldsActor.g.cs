
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsGetCollectionFieldsActor
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
    public static class ReviewSubmissionsGetCollectionFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetCollectionFieldsActor value)
        {
            return value switch
            {
                ReviewSubmissionsGetCollectionFieldsActor.ActorType => "actorType",
                ReviewSubmissionsGetCollectionFieldsActor.ApiKeyId => "apiKeyId",
                ReviewSubmissionsGetCollectionFieldsActor.UserEmail => "userEmail",
                ReviewSubmissionsGetCollectionFieldsActor.UserFirstName => "userFirstName",
                ReviewSubmissionsGetCollectionFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetCollectionFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => ReviewSubmissionsGetCollectionFieldsActor.ActorType,
                "apiKeyId" => ReviewSubmissionsGetCollectionFieldsActor.ApiKeyId,
                "userEmail" => ReviewSubmissionsGetCollectionFieldsActor.UserEmail,
                "userFirstName" => ReviewSubmissionsGetCollectionFieldsActor.UserFirstName,
                "userLastName" => ReviewSubmissionsGetCollectionFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}