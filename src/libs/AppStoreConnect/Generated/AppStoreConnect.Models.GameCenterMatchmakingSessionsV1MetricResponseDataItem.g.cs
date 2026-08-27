
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingSessionsV1MetricResponseDataItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataPoints")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPoint>? DataPoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularityJsonConverter))]
        public global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity? Granularity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingSessionsV1MetricResponseDataItem" /> class.
        /// </summary>
        /// <param name="dataPoints"></param>
        /// <param name="granularity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingSessionsV1MetricResponseDataItem(
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemDataPoint>? dataPoints,
            global::AppStoreConnect.GameCenterMatchmakingSessionsV1MetricResponseDataItemGranularity? granularity)
        {
            this.DataPoints = dataPoints;
            this.Granularity = granularity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingSessionsV1MetricResponseDataItem" /> class.
        /// </summary>
        public GameCenterMatchmakingSessionsV1MetricResponseDataItem()
        {
        }

    }
}