
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAppReviewSubmissionAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("betaReviewState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BetaReviewStateJsonConverter))]
        public global::AppStoreConnect.BetaReviewState? BetaReviewState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedDate")]
        public global::System.DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppReviewSubmissionAttributes" /> class.
        /// </summary>
        /// <param name="betaReviewState"></param>
        /// <param name="submittedDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppReviewSubmissionAttributes(
            global::AppStoreConnect.BetaReviewState? betaReviewState,
            global::System.DateTime? submittedDate)
        {
            this.BetaReviewState = betaReviewState;
            this.SubmittedDate = submittedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppReviewSubmissionAttributes" /> class.
        /// </summary>
        public BetaAppReviewSubmissionAttributes()
        {
        }

    }
}