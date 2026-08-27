
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPointValues
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageSecondsInQueue")]
        public double? AverageSecondsInQueue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50SecondsInQueue")]
        public double? P50SecondsInQueue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95SecondsInQueue")]
        public double? P95SecondsInQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="averageSecondsInQueue"></param>
        /// <param name="p50SecondsInQueue"></param>
        /// <param name="p95SecondsInQueue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPointValues(
            int? count,
            double? averageSecondsInQueue,
            double? p50SecondsInQueue,
            double? p95SecondsInQueue)
        {
            this.Count = count;
            this.AverageSecondsInQueue = averageSecondsInQueue;
            this.P50SecondsInQueue = p50SecondsInQueue;
            this.P95SecondsInQueue = p95SecondsInQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        public GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDataPointValues()
        {
        }

    }
}