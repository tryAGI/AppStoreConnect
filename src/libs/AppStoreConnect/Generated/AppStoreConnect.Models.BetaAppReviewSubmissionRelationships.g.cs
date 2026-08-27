
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAppReviewSubmissionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuild? Build { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppReviewSubmissionRelationships" /> class.
        /// </summary>
        /// <param name="build"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppReviewSubmissionRelationships(
            global::AppStoreConnect.BetaAppReviewSubmissionRelationshipsBuild? build)
        {
            this.Build = build;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppReviewSubmissionRelationships" /> class.
        /// </summary>
        public BetaAppReviewSubmissionRelationships()
        {
        }

    }
}