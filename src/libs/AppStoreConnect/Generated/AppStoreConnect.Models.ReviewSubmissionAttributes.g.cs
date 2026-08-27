
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewSubmissionAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedDate")]
        public global::System.DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.ReviewSubmissionAttributesStateJsonConverter))]
        public global::AppStoreConnect.ReviewSubmissionAttributesState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionAttributes" /> class.
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="submittedDate"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewSubmissionAttributes(
            global::AppStoreConnect.Platform? platform,
            global::System.DateTime? submittedDate,
            global::AppStoreConnect.ReviewSubmissionAttributesState? state)
        {
            this.Platform = platform;
            this.SubmittedDate = submittedDate;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionAttributes" /> class.
        /// </summary>
        public ReviewSubmissionAttributes()
        {
        }

    }
}