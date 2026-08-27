
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterAchievementRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupAchievement")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterAchievementRelationshipsGroupAchievement? GroupAchievement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::AppStoreConnect.GameCenterAchievementRelationshipsReleases? Releases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::AppStoreConnect.GameCenterAchievementRelationshipsActivity? Activity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="localizations"></param>
        /// <param name="releases"></param>
        /// <param name="activity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementRelationships(
            global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterAchievementRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterAchievementRelationshipsLocalizations? localizations,
            global::AppStoreConnect.GameCenterAchievementRelationshipsReleases? releases,
            global::AppStoreConnect.GameCenterAchievementRelationshipsActivity? activity)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.Localizations = localizations;
            this.Releases = releases;
            this.Activity = activity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementRelationships" /> class.
        /// </summary>
        public GameCenterAchievementRelationships()
        {
        }

    }
}