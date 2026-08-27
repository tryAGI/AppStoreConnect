
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataPoints")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint>? DataPoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensions? Dimensions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granularity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularityJsonConverter))]
        public global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity? Granularity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem" /> class.
        /// </summary>
        /// <param name="dataPoints"></param>
        /// <param name="dimensions"></param>
        /// <param name="granularity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem(
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDataPoint>? dataPoints,
            global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemDimensions? dimensions,
            global::AppStoreConnect.GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItemGranularity? granularity)
        {
            this.DataPoints = dataPoints;
            this.Dimensions = dimensions;
            this.Granularity = granularity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem" /> class.
        /// </summary>
        public GameCenterMatchmakingNumberRuleResultsV1MetricResponseDataItem()
        {
        }

    }
}