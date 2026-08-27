
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPointValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averagePlayerCount")]
        public double? AveragePlayerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50PlayerCount")]
        public double? P50PlayerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95PlayerCount")]
        public double? P95PlayerCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="averagePlayerCount"></param>
        /// <param name="p50PlayerCount"></param>
        /// <param name="p95PlayerCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPointValues(
            int? count,
            double? averagePlayerCount,
            double? p50PlayerCount,
            double? p95PlayerCount)
        {
            this.Count = count;
            this.AveragePlayerCount = averagePlayerCount;
            this.P50PlayerCount = p50PlayerCount;
            this.P95PlayerCount = p95PlayerCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        public GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPointValues()
        {
        }

    }
}