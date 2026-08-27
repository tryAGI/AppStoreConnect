
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterAchievementReleaseRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievement")]
        public global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievement? GameCenterAchievement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementReleaseRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterAchievement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementReleaseRelationships(
            global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterAchievementReleaseRelationshipsGameCenterAchievement? gameCenterAchievement)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterAchievement = gameCenterAchievement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementReleaseRelationships" /> class.
        /// </summary>
        public GameCenterAchievementReleaseRelationships()
        {
        }

    }
}