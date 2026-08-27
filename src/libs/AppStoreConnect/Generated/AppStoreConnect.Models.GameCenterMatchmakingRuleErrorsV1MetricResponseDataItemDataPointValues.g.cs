
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPointValues
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPointValues(
            int? count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDataPointValues()
        {
        }

    }
}