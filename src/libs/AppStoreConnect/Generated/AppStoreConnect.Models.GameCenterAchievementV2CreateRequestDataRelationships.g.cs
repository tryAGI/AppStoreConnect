
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAchievementV2CreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersions Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAchievementV2CreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsVersions versions,
            global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterAchievementV2CreateRequestDataRelationshipsGameCenterGroup? gameCenterGroup)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAchievementV2CreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterAchievementV2CreateRequestDataRelationships()
        {
        }

    }
}