
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ActorsGetInstanceFieldsActor
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
    public static class ActorsGetInstanceFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorsGetInstanceFieldsActor value)
        {
            return value switch
            {
                ActorsGetInstanceFieldsActor.ActorType => "actorType",
                ActorsGetInstanceFieldsActor.ApiKeyId => "apiKeyId",
                ActorsGetInstanceFieldsActor.UserEmail => "userEmail",
                ActorsGetInstanceFieldsActor.UserFirstName => "userFirstName",
                ActorsGetInstanceFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorsGetInstanceFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => ActorsGetInstanceFieldsActor.ActorType,
                "apiKeyId" => ActorsGetInstanceFieldsActor.ApiKeyId,
                "userEmail" => ActorsGetInstanceFieldsActor.UserEmail,
                "userFirstName" => ActorsGetInstanceFieldsActor.UserFirstName,
                "userLastName" => ActorsGetInstanceFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}