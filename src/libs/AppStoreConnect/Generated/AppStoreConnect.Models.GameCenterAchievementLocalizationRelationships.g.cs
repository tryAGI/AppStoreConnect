
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterAchievementLocalizationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievement")]
        public global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievement? GameCenterAchievement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievementImage")]
        public global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImage? GameCenterAchievementImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterAchievement"></param>
        /// <param name="gameCenterAchievementImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementLocalizationRelationships(
            global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievement? gameCenterAchievement,
            global::AppStoreConnect.GameCenterAchievementLocalizationRelationshipsGameCenterAchievementImage? gameCenterAchievementImage)
        {
            this.GameCenterAchievement = gameCenterAchievement;
            this.GameCenterAchievementImage = gameCenterAchievementImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationRelationships" /> class.
        /// </summary>
        public GameCenterAchievementLocalizationRelationships()
        {
        }

    }
}