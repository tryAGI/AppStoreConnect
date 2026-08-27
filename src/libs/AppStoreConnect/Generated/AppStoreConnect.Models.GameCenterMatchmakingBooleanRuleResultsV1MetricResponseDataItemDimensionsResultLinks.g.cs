
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResultLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResultLinks" /> class.
        /// </summary>
        /// <param name="groupBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResultLinks(
            string? groupBy)
        {
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResultLinks" /> class.
        /// </summary>
        public GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResultLinks()
        {
        }

    }
}