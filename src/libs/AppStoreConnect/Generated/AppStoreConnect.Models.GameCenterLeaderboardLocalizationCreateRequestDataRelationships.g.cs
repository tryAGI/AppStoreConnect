
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard GameCenterLeaderboard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterLeaderboard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard gameCenterLeaderboard)
        {
            this.GameCenterLeaderboard = gameCenterLeaderboard ?? throw new global::System.ArgumentNullException(nameof(gameCenterLeaderboard));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardLocalizationCreateRequestDataRelationships()
        {
        }

    }
}