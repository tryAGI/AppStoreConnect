
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueueCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSet RuleSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentRuleSet")]
        public global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSet? ExperimentRuleSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="ruleSet"></param>
        /// <param name="experimentRuleSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingQueueCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsRuleSet ruleSet,
            global::AppStoreConnect.GameCenterMatchmakingQueueCreateRequestDataRelationshipsExperimentRuleSet? experimentRuleSet)
        {
            this.RuleSet = ruleSet ?? throw new global::System.ArgumentNullException(nameof(ruleSet));
            this.ExperimentRuleSet = experimentRuleSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterMatchmakingQueueCreateRequestDataRelationships()
        {
        }

    }
}