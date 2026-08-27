
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardV2CreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSets")]
        public global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataRelationshipsGameCenterLeaderboardSets? GameCenterLeaderboardSets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataRelationshipsVersions Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="gameCenterLeaderboardSets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardV2CreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataRelationshipsVersions versions,
            global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterLeaderboardV2CreateRequestDataRelationshipsGameCenterLeaderboardSets? gameCenterLeaderboardSets)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardV2CreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardV2CreateRequestDataRelationships()
        {
        }

    }
}