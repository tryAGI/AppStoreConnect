
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetMemberLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSet")]
        public global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationRelationshipsGameCenterLeaderboardSet? GameCenterLeaderboardSet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboard")]
        public global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationRelationshipsGameCenterLeaderboard? GameCenterLeaderboard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetMemberLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterLeaderboardSet"></param>
        /// <param name="gameCenterLeaderboard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetMemberLocalizationRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationRelationshipsGameCenterLeaderboardSet? gameCenterLeaderboardSet,
            global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationRelationshipsGameCenterLeaderboard? gameCenterLeaderboard)
        {
            this.GameCenterLeaderboardSet = gameCenterLeaderboardSet;
            this.GameCenterLeaderboard = gameCenterLeaderboard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetMemberLocalizationRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetMemberLocalizationRelationships()
        {
        }

    }
}