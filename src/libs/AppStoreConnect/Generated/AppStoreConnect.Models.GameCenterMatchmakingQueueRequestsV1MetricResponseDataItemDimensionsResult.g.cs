
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks? Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultDataJsonConverter))]
        public global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult(
            global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks? links,
            global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultData? data)
        {
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult" /> class.
        /// </summary>
        public GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult()
        {
        }

    }
}