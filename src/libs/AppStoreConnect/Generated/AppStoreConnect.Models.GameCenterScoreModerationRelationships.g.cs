
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterScoreModerationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("player")]
        public global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayer? Player { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterScoreModerationRelationships" /> class.
        /// </summary>
        /// <param name="player"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterScoreModerationRelationships(
            global::AppStoreConnect.GameCenterScoreModerationRelationshipsPlayer? player)
        {
            this.Player = player;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterScoreModerationRelationships" /> class.
        /// </summary>
        public GameCenterScoreModerationRelationships()
        {
        }

    }
}