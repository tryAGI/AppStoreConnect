
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetTestCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchmakingRuleSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSet MatchmakingRuleSet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchmakingRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequests MatchmakingRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetTestCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="matchmakingRuleSet"></param>
        /// <param name="matchmakingRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleSetTestCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRuleSet matchmakingRuleSet,
            global::AppStoreConnect.GameCenterMatchmakingRuleSetTestCreateRequestDataRelationshipsMatchmakingRequests matchmakingRequests)
        {
            this.MatchmakingRuleSet = matchmakingRuleSet ?? throw new global::System.ArgumentNullException(nameof(matchmakingRuleSet));
            this.MatchmakingRequests = matchmakingRequests ?? throw new global::System.ArgumentNullException(nameof(matchmakingRequests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetTestCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleSetTestCreateRequestDataRelationships()
        {
        }

    }
}