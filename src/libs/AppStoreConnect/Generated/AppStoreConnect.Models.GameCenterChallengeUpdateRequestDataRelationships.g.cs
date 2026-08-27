
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterChallengeUpdateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboard")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterChallengeUpdateRequestDataRelationshipsLeaderboard? Leaderboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboardV2")]
        public global::AppStoreConnect.GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardV2? LeaderboardV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="leaderboardV2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeUpdateRequestDataRelationships(
            global::AppStoreConnect.GameCenterChallengeUpdateRequestDataRelationshipsLeaderboardV2? leaderboardV2)
        {
            this.LeaderboardV2 = leaderboardV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeUpdateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterChallengeUpdateRequestDataRelationships()
        {
        }

    }
}