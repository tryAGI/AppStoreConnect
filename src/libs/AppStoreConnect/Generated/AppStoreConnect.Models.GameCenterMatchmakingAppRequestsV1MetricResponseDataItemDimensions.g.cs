
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResult? Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensions(
            global::AppStoreConnect.GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensionsResult? result)
        {
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensions" /> class.
        /// </summary>
        public GameCenterMatchmakingAppRequestsV1MetricResponseDataItemDimensions()
        {
        }

    }
}