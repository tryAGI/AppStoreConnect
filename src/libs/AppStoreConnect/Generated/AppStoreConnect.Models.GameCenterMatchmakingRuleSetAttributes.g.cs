
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleLanguageVersion")]
        public int? RuleLanguageVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minPlayers")]
        public int? MinPlayers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPlayers")]
        public int? MaxPlayers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="ruleLanguageVersion"></param>
        /// <param name="minPlayers"></param>
        /// <param name="maxPlayers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleSetAttributes(
            string? referenceName,
            int? ruleLanguageVersion,
            int? minPlayers,
            int? maxPlayers)
        {
            this.ReferenceName = referenceName;
            this.RuleLanguageVersion = ruleLanguageVersion;
            this.MinPlayers = minPlayers;
            this.MaxPlayers = maxPlayers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleSetAttributes()
        {
        }

    }
}