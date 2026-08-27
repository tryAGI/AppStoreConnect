
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ActorAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.ActorAttributesActorTypeJsonConverter))]
        public global::AppStoreConnect.ActorAttributesActorType? ActorType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userFirstName")]
        public string? UserFirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userLastName")]
        public string? UserLastName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userEmail")]
        public string? UserEmail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyId")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorAttributes" /> class.
        /// </summary>
        /// <param name="actorType"></param>
        /// <param name="userFirstName"></param>
        /// <param name="userLastName"></param>
        /// <param name="userEmail"></param>
        /// <param name="apiKeyId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorAttributes(
            global::AppStoreConnect.ActorAttributesActorType? actorType,
            string? userFirstName,
            string? userLastName,
            string? userEmail,
            string? apiKeyId)
        {
            this.ActorType = actorType;
            this.UserFirstName = userFirstName;
            this.UserLastName = userLastName;
            this.UserEmail = userEmail;
            this.ApiKeyId = apiKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorAttributes" /> class.
        /// </summary>
        public ActorAttributes()
        {
        }

    }
}