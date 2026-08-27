
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterAchievementLocalizationCreateRequestDataRelationshipsGameCenterAchievement GameCenterAchievement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterAchievement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterAchievementLocalizationCreateRequestDataRelationshipsGameCenterAchievement gameCenterAchievement)
        {
            this.GameCenterAchievement = gameCenterAchievement ?? throw new global::System.ArgumentNullException(nameof(gameCenterAchievement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterAchievementLocalizationCreateRequestDataRelationships()
        {
        }

    }
}