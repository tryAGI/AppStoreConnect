
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterActivityRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievements")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterActivityRelationshipsAchievements? Achievements { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievementsV2")]
        public global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2? AchievementsV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboards")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboards? Leaderboards { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboardsV2")]
        public global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2? LeaderboardsV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.GameCenterActivityRelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="achievementsV2"></param>
        /// <param name="leaderboardsV2"></param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterActivityRelationships(
            global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterActivityRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterActivityRelationshipsAchievementsV2? achievementsV2,
            global::AppStoreConnect.GameCenterActivityRelationshipsLeaderboardsV2? leaderboardsV2,
            global::AppStoreConnect.GameCenterActivityRelationshipsVersions? versions)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.AchievementsV2 = achievementsV2;
            this.LeaderboardsV2 = leaderboardsV2;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterActivityRelationships" /> class.
        /// </summary>
        public GameCenterActivityRelationships()
        {
        }

    }
}