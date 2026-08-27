
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetVersionV2InlineCreateRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboardSet")]
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSet? LeaderboardSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetVersionV2InlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="leaderboardSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetVersionV2InlineCreateRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2InlineCreateRelationshipsLeaderboardSet? leaderboardSet)
        {
            this.LeaderboardSet = leaderboardSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetVersionV2InlineCreateRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetVersionV2InlineCreateRelationships()
        {
        }

    }
}