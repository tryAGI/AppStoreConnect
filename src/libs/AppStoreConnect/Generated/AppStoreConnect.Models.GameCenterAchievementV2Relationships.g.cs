
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementV2Relationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivity? Activity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementV2Relationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="activity"></param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementV2Relationships(
            global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterAchievementV2RelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterAchievementV2RelationshipsActivity? activity,
            global::AppStoreConnect.GameCenterAchievementV2RelationshipsVersions? versions)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.Activity = activity;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementV2Relationships" /> class.
        /// </summary>
        public GameCenterAchievementV2Relationships()
        {
        }

    }
}