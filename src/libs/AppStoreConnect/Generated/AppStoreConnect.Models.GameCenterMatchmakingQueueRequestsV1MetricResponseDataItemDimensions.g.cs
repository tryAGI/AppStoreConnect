
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult? Result { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterDetail")]
        public global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsGameCenterDetail? GameCenterDetail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="gameCenterDetail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensions(
            global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResult? result,
            global::AppStoreConnect.GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsGameCenterDetail? gameCenterDetail)
        {
            this.Result = result;
            this.GameCenterDetail = gameCenterDetail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        public GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensions()
        {
        }

    }
}