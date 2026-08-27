
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardVersionV2InlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboard")]
        public global::AppStoreConnect.GameCenterLeaderboardVersionV2InlineCreateRelationshipsLeaderboard? Leaderboard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardVersionV2InlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="leaderboard"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardVersionV2InlineCreateRelationships(
            global::AppStoreConnect.GameCenterLeaderboardVersionV2InlineCreateRelationshipsLeaderboard? leaderboard)
        {
            this.Leaderboard = leaderboard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardVersionV2InlineCreateRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardVersionV2InlineCreateRelationships()
        {
        }

    }
}