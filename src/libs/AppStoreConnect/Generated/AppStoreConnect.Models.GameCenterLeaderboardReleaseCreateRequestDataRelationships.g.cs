
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardReleaseCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetail GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboard GameCenterLeaderboard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardReleaseCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterLeaderboard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardReleaseCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterDetail gameCenterDetail,
            global::AppStoreConnect.GameCenterLeaderboardReleaseCreateRequestDataRelationshipsGameCenterLeaderboard gameCenterLeaderboard)
        {
            this.GameCenterDetail = gameCenterDetail ?? throw new global::System.ArgumentNullException(nameof(gameCenterDetail));
            this.GameCenterLeaderboard = gameCenterLeaderboard ?? throw new global::System.ArgumentNullException(nameof(gameCenterLeaderboard));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardReleaseCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardReleaseCreateRequestDataRelationships()
        {
        }

    }
}