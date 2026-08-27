
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementVersionV2Relationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("achievement")]
        public global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievement? Achievement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementVersionV2Relationships" /> class.
        /// </summary>
        /// <param name="achievement"></param>
        /// <param name="localizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementVersionV2Relationships(
            global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsAchievement? achievement,
            global::AppStoreConnect.GameCenterAchievementVersionV2RelationshipsLocalizations? localizations)
        {
            this.Achievement = achievement;
            this.Localizations = localizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementVersionV2Relationships" /> class.
        /// </summary>
        public GameCenterAchievementVersionV2Relationships()
        {
        }

    }
}