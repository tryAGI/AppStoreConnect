
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gameCenterMatchmakingQueue")]
        public global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue? GameCenterMatchmakingQueue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        /// <param name="gameCenterMatchmakingQueue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensions(
            global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensionsGameCenterMatchmakingQueue? gameCenterMatchmakingQueue)
        {
            this.GameCenterMatchmakingQueue = gameCenterMatchmakingQueue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        public GameCenterMatchmakingRuleErrorsV1MetricResponseDataItemDimensions()
        {
        }

    }
}