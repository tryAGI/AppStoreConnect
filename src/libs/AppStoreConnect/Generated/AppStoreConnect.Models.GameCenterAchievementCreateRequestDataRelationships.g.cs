
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterAchievementCreateRequestDataRelationshipsGameCenterGroup? gameCenterGroup)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterAchievementCreateRequestDataRelationships()
        {
        }

    }
}