
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterChallengeCreateRequestDataRelationshipsLeaderboardData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataTypeJsonConverter))]
        public global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeCreateRequestDataRelationshipsLeaderboardData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeCreateRequestDataRelationshipsLeaderboardData(
            string id,
            global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsLeaderboardDataType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeCreateRequestDataRelationshipsLeaderboardData" /> class.
        /// </summary>
        public GameCenterChallengeCreateRequestDataRelationshipsLeaderboardData()
        {
        }

    }
}