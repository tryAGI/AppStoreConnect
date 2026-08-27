
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GameCenterChallengeRelationshipsLeaderboard
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.RelationshipLinks? Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeRelationshipsLeaderboard" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterChallengeRelationshipsLeaderboard(
            global::AppStoreConnect.RelationshipLinks? links,
            global::AppStoreConnect.GameCenterChallengeRelationshipsLeaderboardData? data)
        {
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterChallengeRelationshipsLeaderboard" /> class.
        /// </summary>
        public GameCenterChallengeRelationshipsLeaderboard()
        {
        }

    }
}