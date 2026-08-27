
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPointValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageNumberOfRequests")]
        public double? AverageNumberOfRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50NumberOfRequests")]
        public double? P50NumberOfRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95NumberOfRequests")]
        public double? P95NumberOfRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="averageNumberOfRequests"></param>
        /// <param name="p50NumberOfRequests"></param>
        /// <param name="p95NumberOfRequests"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPointValues(
            int? count,
            double? averageNumberOfRequests,
            double? p50NumberOfRequests,
            double? p95NumberOfRequests)
        {
            this.Count = count;
            this.AverageNumberOfRequests = averageNumberOfRequests;
            this.P50NumberOfRequests = p50NumberOfRequests;
            this.P95NumberOfRequests = p95NumberOfRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        public GameCenterMatchmakingQueueSizesV1MetricResponseDataItemDataPointValues()
        {
        }

    }
}