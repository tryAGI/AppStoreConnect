
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardVersionV2Relationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboard")]
        public global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboard? Leaderboard { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardVersionV2Relationships" /> class.
        /// </summary>
        /// <param name="leaderboard"></param>
        /// <param name="localizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardVersionV2Relationships(
            global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLeaderboard? leaderboard,
            global::AppStoreConnect.GameCenterLeaderboardVersionV2RelationshipsLocalizations? localizations)
        {
            this.Leaderboard = leaderboard;
            this.Localizations = localizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardVersionV2Relationships" /> class.
        /// </summary>
        public GameCenterLeaderboardVersionV2Relationships()
        {
        }

    }
}