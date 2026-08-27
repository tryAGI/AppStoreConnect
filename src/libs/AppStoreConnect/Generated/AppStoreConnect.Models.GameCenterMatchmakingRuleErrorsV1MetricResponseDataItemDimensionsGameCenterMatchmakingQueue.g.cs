
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueueLinks? Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue(
            global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueueLinks? links,
            string? data)
        {
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue()
        {
        }

    }
}