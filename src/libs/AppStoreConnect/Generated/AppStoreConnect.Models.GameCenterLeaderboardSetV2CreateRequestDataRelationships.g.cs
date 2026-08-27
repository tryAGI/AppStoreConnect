
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetV2CreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboards")]
        public global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboards? GameCenterLeaderboards { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersions Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="gameCenterLeaderboards"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetV2CreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsVersions versions,
            global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterLeaderboardSetV2CreateRequestDataRelationshipsGameCenterLeaderboards? gameCenterLeaderboards)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.GameCenterLeaderboards = gameCenterLeaderboards;
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetV2CreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetV2CreateRequestDataRelationships()
        {
        }

    }
}