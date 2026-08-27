
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPointValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageResult")]
        public double? AverageResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50Result")]
        public double? P50Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95Result")]
        public double? P95Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="averageResult"></param>
        /// <param name="p50Result"></param>
        /// <param name="p95Result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPointValues(
            int? count,
            double? averageResult,
            double? p50Result,
            double? p95Result)
        {
            this.Count = count;
            this.AverageResult = averageResult;
            this.P50Result = p50Result;
            this.P95Result = p95Result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        public GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPointValues()
        {
        }

    }
}