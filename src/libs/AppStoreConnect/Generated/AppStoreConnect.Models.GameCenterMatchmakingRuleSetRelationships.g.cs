
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeams? Teams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRules? Rules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchmakingQueues")]
        public global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueues? MatchmakingQueues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetRelationships" /> class.
        /// </summary>
        /// <param name="teams"></param>
        /// <param name="rules"></param>
        /// <param name="matchmakingQueues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleSetRelationships(
            global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsTeams? teams,
            global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsRules? rules,
            global::AppStoreConnect.GameCenterMatchmakingRuleSetRelationshipsMatchmakingQueues? matchmakingQueues)
        {
            this.Teams = teams;
            this.Rules = rules;
            this.MatchmakingQueues = matchmakingQueues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetRelationships" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleSetRelationships()
        {
        }

    }
}