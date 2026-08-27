
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterAchievementImageCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterAchievementLocalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterAchievementImageCreateRequestDataRelationshipsGameCenterAchievementLocalization GameCenterAchievementLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementImageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterAchievementLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementImageCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterAchievementImageCreateRequestDataRelationshipsGameCenterAchievementLocalization gameCenterAchievementLocalization)
        {
            this.GameCenterAchievementLocalization = gameCenterAchievementLocalization ?? throw new global::System.ArgumentNullException(nameof(gameCenterAchievementLocalization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementImageCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterAchievementImageCreateRequestDataRelationships()
        {
        }

    }
}