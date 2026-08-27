
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterLeaderboardImageCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterLeaderboardLocalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardImageCreateRequestDataRelationshipsGameCenterLeaderboardLocalization GameCenterLeaderboardLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardImageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="gameCenterLeaderboardLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardImageCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterLeaderboardImageCreateRequestDataRelationshipsGameCenterLeaderboardLocalization gameCenterLeaderboardLocalization)
        {
            this.GameCenterLeaderboardLocalization = gameCenterLeaderboardLocalization ?? throw new global::System.ArgumentNullException(nameof(gameCenterLeaderboardLocalization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardImageCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterLeaderboardImageCreateRequestDataRelationships()
        {
        }

    }
}