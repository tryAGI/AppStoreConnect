
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingTestRequestInlineCreateRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchmakingPlayerProperties")]
        public global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerProperties? MatchmakingPlayerProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestRequestInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="matchmakingPlayerProperties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingTestRequestInlineCreateRelationships(
            global::AppStoreConnect.GameCenterMatchmakingTestRequestInlineCreateRelationshipsMatchmakingPlayerProperties? matchmakingPlayerProperties)
        {
            this.MatchmakingPlayerProperties = matchmakingPlayerProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTestRequestInlineCreateRelationships" /> class.
        /// </summary>
        public GameCenterMatchmakingTestRequestInlineCreateRelationships()
        {
        }

    }
}