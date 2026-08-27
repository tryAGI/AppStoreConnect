
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardV2Relationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSets")]
        public global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSets? GameCenterLeaderboardSets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivity? Activity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challenge")]
        public global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallenge? Challenge { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardV2Relationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="gameCenterLeaderboardSets"></param>
        /// <param name="activity"></param>
        /// <param name="challenge"></param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardV2Relationships(
            global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsGameCenterLeaderboardSets? gameCenterLeaderboardSets,
            global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsActivity? activity,
            global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsChallenge? challenge,
            global::AppStoreConnect.GameCenterLeaderboardV2RelationshipsVersions? versions)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            this.Activity = activity;
            this.Challenge = challenge;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardV2Relationships" /> class.
        /// </summary>
        public GameCenterLeaderboardV2Relationships()
        {
        }

    }
}