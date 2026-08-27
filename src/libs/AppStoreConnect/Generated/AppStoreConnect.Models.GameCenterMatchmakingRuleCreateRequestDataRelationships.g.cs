
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSet RuleSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="ruleSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterMatchmakingRuleCreateRequestDataRelationshipsRuleSet ruleSet)
        {
            this.RuleSet = ruleSet ?? throw new global::System.ArgumentNullException(nameof(ruleSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleCreateRequestDataRelationships()
        {
        }

    }
}