
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueueUpdateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleSet")]
        public global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSet? RuleSet { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentRuleSet")]
        public global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSet? ExperimentRuleSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="ruleSet"></param>
        /// <param name="experimentRuleSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingQueueUpdateRequestDataRelationships(
            global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsRuleSet? ruleSet,
            global::AppStoreConnect.GameCenterMatchmakingQueueUpdateRequestDataRelationshipsExperimentRuleSet? experimentRuleSet)
        {
            this.RuleSet = ruleSet;
            this.ExperimentRuleSet = experimentRuleSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueUpdateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterMatchmakingQueueUpdateRequestDataRelationships()
        {
        }

    }
}