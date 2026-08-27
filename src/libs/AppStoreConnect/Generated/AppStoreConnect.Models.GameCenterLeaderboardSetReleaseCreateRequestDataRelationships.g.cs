
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetReleaseCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterDetail GameCenterDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSet GameCenterLeaderboardSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetReleaseCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterLeaderboardSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetReleaseCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterDetail gameCenterDetail,
            global::AppStoreConnect.GameCenterLeaderboardSetReleaseCreateRequestDataRelationshipsGameCenterLeaderboardSet gameCenterLeaderboardSet)
        {
            this.GameCenterDetail = gameCenterDetail ?? throw new global::System.ArgumentNullException(nameof(gameCenterDetail));
            this.GameCenterLeaderboardSet = gameCenterLeaderboardSet ?? throw new global::System.ArgumentNullException(nameof(gameCenterLeaderboardSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetReleaseCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetReleaseCreateRequestDataRelationships()
        {
        }

    }
}