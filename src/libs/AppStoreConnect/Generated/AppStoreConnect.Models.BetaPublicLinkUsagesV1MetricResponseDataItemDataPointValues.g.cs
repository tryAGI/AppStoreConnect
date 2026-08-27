
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaPublicLinkUsagesV1MetricResponseDataItemDataPointValues
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("viewCount")]
        public int? ViewCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptedCount")]
        public int? AcceptedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("didNotAcceptCount")]
        public int? DidNotAcceptCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("didNotMeetCriteriaCount")]
        public int? DidNotMeetCriteriaCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notRelevantRatio")]
        public double? NotRelevantRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notClearRatio")]
        public double? NotClearRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notInterestingRatio")]
        public double? NotInterestingRatio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPublicLinkUsagesV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        /// <param name="viewCount"></param>
        /// <param name="acceptedCount"></param>
        /// <param name="didNotAcceptCount"></param>
        /// <param name="didNotMeetCriteriaCount"></param>
        /// <param name="notRelevantRatio"></param>
        /// <param name="notClearRatio"></param>
        /// <param name="notInterestingRatio"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPublicLinkUsagesV1MetricResponseDataItemDataPointValues(
            int? viewCount,
            int? acceptedCount,
            int? didNotAcceptCount,
            int? didNotMeetCriteriaCount,
            double? notRelevantRatio,
            double? notClearRatio,
            double? notInterestingRatio)
        {
            this.ViewCount = viewCount;
            this.AcceptedCount = acceptedCount;
            this.DidNotAcceptCount = didNotAcceptCount;
            this.DidNotMeetCriteriaCount = didNotMeetCriteriaCount;
            this.NotRelevantRatio = notRelevantRatio;
            this.NotClearRatio = notClearRatio;
            this.NotInterestingRatio = notInterestingRatio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPublicLinkUsagesV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        public BetaPublicLinkUsagesV1MetricResponseDataItemDataPointValues()
        {
        }

    }
}