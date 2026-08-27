
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboard
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboard" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboard(
            global::AppStoreConnect.GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboardData? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboard" /> class.
        /// </summary>
        public GameCenterDetailUpdateRequestDataRelationshipsDefaultLeaderboard()
        {
        }

    }
}