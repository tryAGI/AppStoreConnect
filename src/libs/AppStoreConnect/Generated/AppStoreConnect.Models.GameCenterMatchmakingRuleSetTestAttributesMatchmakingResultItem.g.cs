
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestName")]
        public string? RequestName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamAssignments")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingTeamAssignment>? TeamAssignments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem" /> class.
        /// </summary>
        /// <param name="requestName"></param>
        /// <param name="teamAssignments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem(
            string? requestName,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingTeamAssignment>? teamAssignments)
        {
            this.RequestName = requestName;
            this.TeamAssignments = teamAssignments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleSetTestAttributesMatchmakingResultItem()
        {
        }

    }
}