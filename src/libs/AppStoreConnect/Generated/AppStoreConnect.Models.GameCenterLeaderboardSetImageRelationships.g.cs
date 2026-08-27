
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetImageRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSetLocalization")]
        public global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalization? GameCenterLeaderboardSetLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetImageRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterLeaderboardSetLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetImageRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalization? gameCenterLeaderboardSetLocalization)
        {
            this.GameCenterLeaderboardSetLocalization = gameCenterLeaderboardSetLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetImageRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetImageRelationships()
        {
        }

    }
}