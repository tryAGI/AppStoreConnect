
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardLocalizationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboard")]
        public global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboard? GameCenterLeaderboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardImage")]
        public global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImage? GameCenterLeaderboardImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterLeaderboard"></param>
        /// <param name="gameCenterLeaderboardImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardLocalizationRelationships(
            global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboard? gameCenterLeaderboard,
            global::AppStoreConnect.GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardImage? gameCenterLeaderboardImage)
        {
            this.GameCenterLeaderboard = gameCenterLeaderboard;
            this.GameCenterLeaderboardImage = gameCenterLeaderboardImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardLocalizationRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardLocalizationRelationships()
        {
        }

    }
}