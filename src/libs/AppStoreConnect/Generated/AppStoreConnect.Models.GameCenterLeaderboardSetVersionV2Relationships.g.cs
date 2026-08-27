
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetVersionV2Relationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboardSet")]
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSet? LeaderboardSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetVersionV2Relationships" /> class.
        /// </summary>
        /// <param name="leaderboardSet"></param>
        /// <param name="localizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetVersionV2Relationships(
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLeaderboardSet? leaderboardSet,
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2RelationshipsLocalizations? localizations)
        {
            this.LeaderboardSet = leaderboardSet;
            this.Localizations = localizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetVersionV2Relationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetVersionV2Relationships()
        {
        }

    }
}