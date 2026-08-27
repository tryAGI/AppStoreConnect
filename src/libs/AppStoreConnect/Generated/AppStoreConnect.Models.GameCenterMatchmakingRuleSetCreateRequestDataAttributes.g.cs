
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleLanguageVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RuleLanguageVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minPlayers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinPlayers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPlayers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxPlayers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
        /// <param name="ruleLanguageVersion"></param>
        /// <param name="minPlayers"></param>
        /// <param name="maxPlayers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleSetCreateRequestDataAttributes(
            string referenceName,
            int ruleLanguageVersion,
            int minPlayers,
            int maxPlayers)
        {
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
            this.RuleLanguageVersion = ruleLanguageVersion;
            this.MinPlayers = minPlayers;
            this.MaxPlayers = maxPlayers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetCreateRequestDataAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleSetCreateRequestDataAttributes()
        {
        }

    }
}