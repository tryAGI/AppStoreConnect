
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetVersionV2CreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaderboardSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSet LeaderboardSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetVersionV2CreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="leaderboardSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetVersionV2CreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetVersionV2CreateRequestDataRelationshipsLeaderboardSet leaderboardSet)
        {
            this.LeaderboardSet = leaderboardSet ?? throw new global::System.ArgumentNullException(nameof(leaderboardSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetVersionV2CreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetVersionV2CreateRequestDataRelationships()
        {
        }

    }
}