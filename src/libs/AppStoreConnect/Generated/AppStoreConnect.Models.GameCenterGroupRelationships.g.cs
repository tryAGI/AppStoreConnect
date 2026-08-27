
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterGroupRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetails")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetails? GameCenterDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboards")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboards? GameCenterLeaderboards { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardsV2")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2? GameCenterLeaderboardsV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSets")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSets? GameCenterLeaderboardSets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSetsV2")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2? GameCenterLeaderboardSetsV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievements")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievements? GameCenterAchievements { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievementsV2")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2? GameCenterAchievementsV2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterActivities")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivities? GameCenterActivities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterChallenges")]
        public global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallenges? GameCenterChallenges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterGroupRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetails"></param>
        /// <param name="gameCenterLeaderboardsV2"></param>
        /// <param name="gameCenterLeaderboardSetsV2"></param>
        /// <param name="gameCenterAchievementsV2"></param>
        /// <param name="gameCenterActivities"></param>
        /// <param name="gameCenterChallenges"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterGroupRelationships(
            global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterDetails? gameCenterDetails,
            global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardsV2? gameCenterLeaderboardsV2,
            global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterLeaderboardSetsV2? gameCenterLeaderboardSetsV2,
            global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterAchievementsV2? gameCenterAchievementsV2,
            global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterActivities? gameCenterActivities,
            global::AppStoreConnect.GameCenterGroupRelationshipsGameCenterChallenges? gameCenterChallenges)
        {
            this.GameCenterDetails = gameCenterDetails;
            this.GameCenterLeaderboardsV2 = gameCenterLeaderboardsV2;
            this.GameCenterLeaderboardSetsV2 = gameCenterLeaderboardSetsV2;
            this.GameCenterAchievementsV2 = gameCenterAchievementsV2;
            this.GameCenterActivities = gameCenterActivities;
            this.GameCenterChallenges = gameCenterChallenges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterGroupRelationships" /> class.
        /// </summary>
        public GameCenterGroupRelationships()
        {
        }

    }
}