
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActorsGetCollectionFieldsActor
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
    public static class ActorsGetCollectionFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActorsGetCollectionFieldsActor value)
        {
            return value switch
            {
                ActorsGetCollectionFieldsActor.ActorType => "actorType",
                ActorsGetCollectionFieldsActor.ApiKeyId => "apiKeyId",
                ActorsGetCollectionFieldsActor.UserEmail => "userEmail",
                ActorsGetCollectionFieldsActor.UserFirstName => "userFirstName",
                ActorsGetCollectionFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActorsGetCollectionFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => ActorsGetCollectionFieldsActor.ActorType,
                "apiKeyId" => ActorsGetCollectionFieldsActor.ApiKeyId,
                "userEmail" => ActorsGetCollectionFieldsActor.UserEmail,
                "userFirstName" => ActorsGetCollectionFieldsActor.UserFirstName,
                "userLastName" => ActorsGetCollectionFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}