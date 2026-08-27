
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResult? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterMatchmakingQueue")]
        public global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue? GameCenterMatchmakingQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="gameCenterMatchmakingQueue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensions(
            global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsResult? result,
            global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue? gameCenterMatchmakingQueue)
        {
            this.Result = result;
            this.GameCenterMatchmakingQueue = gameCenterMatchmakingQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        public GameCenterMatchmakingBooleanRuleResultsV1MetricResponseDataItemDimensions()
        {
        }

    }
}