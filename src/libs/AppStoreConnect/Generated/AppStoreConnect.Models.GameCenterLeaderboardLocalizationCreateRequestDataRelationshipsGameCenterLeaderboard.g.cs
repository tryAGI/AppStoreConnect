
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard(
            global::AppStoreConnect.GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboardData data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard" /> class.
        /// </summary>
        public GameCenterLeaderboardLocalizationCreateRequestDataRelationshipsGameCenterLeaderboard()
        {
        }

    }
}