
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSet GameCenterLeaderboardSet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard GameCenterLeaderboard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterLeaderboardSet"></param>
        /// <param name="gameCenterLeaderboard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardSet gameCenterLeaderboardSet,
            global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard gameCenterLeaderboard)
        {
            this.GameCenterLeaderboardSet = gameCenterLeaderboardSet ?? throw new global::System.ArgumentNullException(nameof(gameCenterLeaderboardSet));
            this.GameCenterLeaderboard = gameCenterLeaderboard ?? throw new global::System.ArgumentNullException(nameof(gameCenterLeaderboard));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetMemberLocalizationCreateRequestDataRelationships()
        {
        }

    }
}