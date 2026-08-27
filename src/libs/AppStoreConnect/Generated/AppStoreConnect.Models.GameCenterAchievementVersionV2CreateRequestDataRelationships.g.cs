
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementVersionV2CreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievement")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterAchievementVersionV2CreateRequestDataRelationshipsAchievement Achievement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementVersionV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="achievement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementVersionV2CreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterAchievementVersionV2CreateRequestDataRelationshipsAchievement achievement)
        {
            this.Achievement = achievement ?? throw new global::System.ArgumentNullException(nameof(achievement));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementVersionV2CreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterAchievementVersionV2CreateRequestDataRelationships()
        {
        }

    }
}