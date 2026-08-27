
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterChallengeRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.GameCenterChallengeRelationshipsVersions? Versions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboard")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboard? Leaderboard { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboardV2")]
        public global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2? LeaderboardV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="versions"></param>
        /// <param name="leaderboardV2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeRelationships(
            global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterChallengeRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterChallengeRelationshipsVersions? versions,
            global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardV2? leaderboardV2)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.Versions = versions;
            this.LeaderboardV2 = leaderboardV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeRelationships" /> class.
        /// </summary>
        public GameCenterChallengeRelationships()
        {
        }

    }
}