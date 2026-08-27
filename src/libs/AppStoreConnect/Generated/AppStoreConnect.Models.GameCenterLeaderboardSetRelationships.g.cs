
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterGroup")]
        public global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroup? GameCenterGroup { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupLeaderboardSet")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGroupLeaderboardSet? GroupLeaderboardSet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboards")]
        public global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboards? GameCenterLeaderboards { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releases")]
        public global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleases? Releases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterDetail"></param>
        /// <param name="gameCenterGroup"></param>
        /// <param name="localizations"></param>
        /// <param name="gameCenterLeaderboards"></param>
        /// <param name="releases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterDetail? gameCenterDetail,
            global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterGroup? gameCenterGroup,
            global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsLocalizations? localizations,
            global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsGameCenterLeaderboards? gameCenterLeaderboards,
            global::AppStoreConnect.GameCenterLeaderboardSetRelationshipsReleases? releases)
        {
            this.GameCenterDetail = gameCenterDetail;
            this.GameCenterGroup = gameCenterGroup;
            this.Localizations = localizations;
            this.GameCenterLeaderboards = gameCenterLeaderboards;
            this.Releases = releases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetRelationships()
        {
        }

    }
}