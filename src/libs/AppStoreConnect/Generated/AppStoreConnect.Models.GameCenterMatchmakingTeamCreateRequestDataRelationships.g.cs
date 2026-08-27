
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingTeamCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSet RuleSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTeamCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="ruleSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingTeamCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterMatchmakingTeamCreateRequestDataRelationshipsRuleSet ruleSet)
        {
            this.RuleSet = ruleSet ?? throw new global::System.ArgumentNullException(nameof(ruleSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingTeamCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterMatchmakingTeamCreateRequestDataRelationships()
        {
        }

    }
}