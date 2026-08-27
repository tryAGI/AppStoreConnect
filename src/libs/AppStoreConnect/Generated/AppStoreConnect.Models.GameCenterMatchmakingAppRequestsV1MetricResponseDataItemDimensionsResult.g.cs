
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultLinks? Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultDataJsonConverter))]
        public global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResult" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResult(
            global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultLinks? links,
            global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResultData? data)
        {
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResult" /> class.
        /// </summary>
        public GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResult()
        {
        }

    }
}