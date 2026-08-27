
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementImageV2Relationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localization")]
        public global::AppStoreConnect.GameCenterAchievementImageV2RelationshipsLocalization? Localization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementImageV2Relationships" /> class.
        /// </summary>
        /// <param name="localization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementImageV2Relationships(
            global::AppStoreConnect.GameCenterAchievementImageV2RelationshipsLocalization? localization)
        {
            this.Localization = localization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementImageV2Relationships" /> class.
        /// </summary>
        public GameCenterAchievementImageV2Relationships()
        {
        }

    }
}