
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsGetInstanceFieldsActor
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
    public static class ReviewSubmissionsGetInstanceFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetInstanceFieldsActor value)
        {
            return value switch
            {
                ReviewSubmissionsGetInstanceFieldsActor.ActorType => "actorType",
                ReviewSubmissionsGetInstanceFieldsActor.ApiKeyId => "apiKeyId",
                ReviewSubmissionsGetInstanceFieldsActor.UserEmail => "userEmail",
                ReviewSubmissionsGetInstanceFieldsActor.UserFirstName => "userFirstName",
                ReviewSubmissionsGetInstanceFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetInstanceFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => ReviewSubmissionsGetInstanceFieldsActor.ActorType,
                "apiKeyId" => ReviewSubmissionsGetInstanceFieldsActor.ApiKeyId,
                "userEmail" => ReviewSubmissionsGetInstanceFieldsActor.UserEmail,
                "userFirstName" => ReviewSubmissionsGetInstanceFieldsActor.UserFirstName,
                "userLastName" => ReviewSubmissionsGetInstanceFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}