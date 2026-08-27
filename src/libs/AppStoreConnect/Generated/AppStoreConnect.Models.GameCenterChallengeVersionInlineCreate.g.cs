
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterChallengeVersionInlineCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterChallengeVersionInlineCreateTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterChallengeVersionInlineCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.GameCenterChallengeVersionInlineCreateRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionInlineCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeVersionInlineCreate(
            global::AppStoreConnect.GameCenterChallengeVersionInlineCreateType type,
            string? id,
            global::AppStoreConnect.GameCenterChallengeVersionInlineCreateRelationships? relationships)
        {
            this.Type = type;
            this.Id = id;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeVersionInlineCreate" /> class.
        /// </summary>
        public GameCenterChallengeVersionInlineCreate()
        {
        }

    }
}