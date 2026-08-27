
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardSetImageCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardSetLocalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardSetImageCreateRequestDataRelationshipsGameCenterLeaderboardSetLocalization GameCenterLeaderboardSetLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetImageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterLeaderboardSetLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardSetImageCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardSetImageCreateRequestDataRelationshipsGameCenterLeaderboardSetLocalization gameCenterLeaderboardSetLocalization)
        {
            this.GameCenterLeaderboardSetLocalization = gameCenterLeaderboardSetLocalization ?? throw new global::System.ArgumentNullException(nameof(gameCenterLeaderboardSetLocalization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardSetImageCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardSetImageCreateRequestDataRelationships()
        {
        }

    }
}