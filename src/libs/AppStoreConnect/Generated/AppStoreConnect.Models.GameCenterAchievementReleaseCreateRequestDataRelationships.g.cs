
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementReleaseCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetail GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievement GameCenterAchievement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementReleaseCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterAchievement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementReleaseCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterDetail gameCenterDetail,
            global::AppStoreConnect.GameCenterAchievementReleaseCreateRequestDataRelationshipsGameCenterAchievement gameCenterAchievement)
        {
            this.GameCenterDetail = gameCenterDetail ?? throw new global::System.ArgumentNullException(nameof(gameCenterDetail));
            this.GameCenterAchievement = gameCenterAchievement ?? throw new global::System.ArgumentNullException(nameof(gameCenterAchievement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementReleaseCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterAchievementReleaseCreateRequestDataRelationships()
        {
        }

    }
}