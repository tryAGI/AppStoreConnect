
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterChallengeCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboard")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsLeaderboard? Leaderboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboardV2")]
        public global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsLeaderboardV2? LeaderboardV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="versions"></param>
        /// <param name="leaderboardV2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsVersions? versions,
            global::AppStoreConnect.GameCenterChallengeCreateRequestDataRelationshipsLeaderboardV2? leaderboardV2)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.Versions = versions;
            this.LeaderboardV2 = leaderboardV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterChallengeCreateRequestDataRelationships()
        {
        }

    }
}