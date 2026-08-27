
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterChallengeImageCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterChallengeImageCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeImageCreateRequestData" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="type"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeImageCreateRequestData(
            global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataAttributes attributes,
            global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataType type,
            global::AppStoreConnect.GameCenterChallengeImageCreateRequestDataRelationships? relationships)
        {
            this.Type = type;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeImageCreateRequestData" /> class.
        /// </summary>
        public GameCenterChallengeImageCreateRequestData()
        {
        }

    }
}