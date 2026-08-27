
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetTestAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchmakingResults")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>>? MatchmakingResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetTestAttributes" /> class.
        /// </summary>
        /// <param name="matchmakingResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleSetTestAttributes(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem>>? matchmakingResults)
        {
            this.MatchmakingResults = matchmakingResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetTestAttributes" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleSetTestAttributes()
        {
        }

    }
}