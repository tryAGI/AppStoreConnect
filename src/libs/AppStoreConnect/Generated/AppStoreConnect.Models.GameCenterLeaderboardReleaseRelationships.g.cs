
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardReleaseRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboard")]
        public global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboard? GameCenterLeaderboard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardReleaseRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterLeaderboard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardReleaseRelationships(
            global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterLeaderboardReleaseRelationshipsGameCenterLeaderboard? gameCenterLeaderboard)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterLeaderboard = gameCenterLeaderboard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardReleaseRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardReleaseRelationships()
        {
        }

    }
}