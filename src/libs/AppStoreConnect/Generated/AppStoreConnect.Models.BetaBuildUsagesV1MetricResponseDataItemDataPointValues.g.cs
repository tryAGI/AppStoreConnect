
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaBuildUsagesV1MetricResponseDataItemDataPointValues
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crashCount")]
        public int? CrashCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installCount")]
        public int? InstallCount { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inviteCount")]
        public int? InviteCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildUsagesV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        /// <param name="crashCount"></param>
        /// <param name="installCount"></param>
        /// <param name="sessionCount"></param>
        /// <param name="feedbackCount"></param>
        /// <param name="inviteCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBuildUsagesV1MetricResponseDataItemDataPointValues(
            int? crashCount,
            int? installCount,
            int? sessionCount,
            int? feedbackCount,
            int? inviteCount)
        {
            this.CrashCount = crashCount;
            this.InstallCount = installCount;
            this.SessionCount = sessionCount;
            this.FeedbackCount = feedbackCount;
            this.InviteCount = inviteCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildUsagesV1MetricResponseDataItemDataPointValues" /> class.
        /// </summary>
        public BetaBuildUsagesV1MetricResponseDataItemDataPointValues()
        {
        }

    }
}