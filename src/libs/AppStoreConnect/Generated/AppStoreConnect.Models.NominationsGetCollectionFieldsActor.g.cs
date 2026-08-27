
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationsGetCollectionFieldsActor
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
    public static class NominationsGetCollectionFieldsActorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsGetCollectionFieldsActor value)
        {
            return value switch
            {
                NominationsGetCollectionFieldsActor.ActorType => "actorType",
                NominationsGetCollectionFieldsActor.ApiKeyId => "apiKeyId",
                NominationsGetCollectionFieldsActor.UserEmail => "userEmail",
                NominationsGetCollectionFieldsActor.UserFirstName => "userFirstName",
                NominationsGetCollectionFieldsActor.UserLastName => "userLastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsGetCollectionFieldsActor? ToEnum(string value)
        {
            return value switch
            {
                "actorType" => NominationsGetCollectionFieldsActor.ActorType,
                "apiKeyId" => NominationsGetCollectionFieldsActor.ApiKeyId,
                "userEmail" => NominationsGetCollectionFieldsActor.UserEmail,
                "userFirstName" => NominationsGetCollectionFieldsActor.UserFirstName,
                "userLastName" => NominationsGetCollectionFieldsActor.UserLastName,
                _ => null,
            };
        }
    }
}