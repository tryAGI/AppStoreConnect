
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupBy")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks" /> class.
        /// </summary>
        /// <param name="groupBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks(
            string? groupBy)
        {
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks" /> class.
        /// </summary>
        public GameCenterMatchmakingQueueRequestsV1MetricResponseDataItemDimensionsResultLinks()
        {
        }

    }
}