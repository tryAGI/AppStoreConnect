
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaTesterUsagesV1MetricResponseDataItemDataPointValues
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crashCount")]
        public int? CrashCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionCount")]
        public int? SessionCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbackCount")]
        public int? FeedbackCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterUsagesV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        /// <param name="crashCount"></param>
        /// <param name="sessionCount"></param>
        /// <param name="feedbackCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterUsagesV1MetricResponseDataItemDataPointValues(
            int? crashCount,
            int? sessionCount,
            int? feedbackCount)
        {
            this.CrashCount = crashCount;
            this.SessionCount = sessionCount;
            this.FeedbackCount = feedbackCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterUsagesV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        public BetaTesterUsagesV1MetricResponseDataItemDataPointValues()
        {
        }

    }
}