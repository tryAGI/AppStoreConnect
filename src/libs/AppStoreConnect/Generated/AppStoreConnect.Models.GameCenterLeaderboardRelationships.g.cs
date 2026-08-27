
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupLeaderboard")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterLeaderboardRelationshipsGroupLeaderboard? GroupLeaderboard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSets")]
        public global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSets? GameCenterLeaderboardSets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleases? Releases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivity? Activity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("challenge")]
        public global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallenge? Challenge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="gameCenterLeaderboardSets"></param>
        /// <param name="localizations"></param>
        /// <param name="releases"></param>
        /// <param name="activity"></param>
        /// <param name="challenge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardRelationships(
            global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterLeaderboardRelationshipsGameCenterLeaderboardSets? gameCenterLeaderboardSets,
            global::AppStoreConnect.GameCenterLeaderboardRelationshipsLocalizations? localizations,
            global::AppStoreConnect.GameCenterLeaderboardRelationshipsReleases? releases,
            global::AppStoreConnect.GameCenterLeaderboardRelationshipsActivity? activity,
            global::AppStoreConnect.GameCenterLeaderboardRelationshipsChallenge? challenge)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.GameCenterLeaderboardSets = gameCenterLeaderboardSets;
            this.Localizations = localizations;
            this.Releases = releases;
            this.Activity = activity;
            this.Challenge = challenge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardRelationships()
        {
        }

    }
}