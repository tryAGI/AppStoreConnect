
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsGetInstanceFieldsActor
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
    public static class NominationsGetInstanceFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetInstanceFieldsActor value)
        {
            return value switch
            {
                NominationsGetInstanceFieldsActor.ActorType => "actorType",
                NominationsGetInstanceFieldsActor.ApiKeyId => "apiKeyId",
                NominationsGetInstanceFieldsActor.UserEmail => "userEmail",
                NominationsGetInstanceFieldsActor.UserFirstName => "userFirstName",
                NominationsGetInstanceFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetInstanceFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => NominationsGetInstanceFieldsActor.ActorType,
                "apiKeyId" => NominationsGetInstanceFieldsActor.ApiKeyId,
                "userEmail" => NominationsGetInstanceFieldsActor.UserEmail,
                "userFirstName" => NominationsGetInstanceFieldsActor.UserFirstName,
                "userLastName" => NominationsGetInstanceFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}