
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReviewSubmissionRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.ReviewSubmissionRelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::AppStoreConnect.ReviewSubmissionRelationshipsItems? Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionForReview")]
        public global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReview? AppStoreVersionForReview { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedByActor")]
        public global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActor? SubmittedByActor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedByActor")]
        public global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActor? LastUpdatedByActor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="items"></param>
        /// <param name="appStoreVersionForReview"></param>
        /// <param name="submittedByActor"></param>
        /// <param name="lastUpdatedByActor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewSubmissionRelationships(
            global::AppStoreConnect.ReviewSubmissionRelationshipsApp? app,
            global::AppStoreConnect.ReviewSubmissionRelationshipsItems? items,
            global::AppStoreConnect.ReviewSubmissionRelationshipsAppStoreVersionForReview? appStoreVersionForReview,
            global::AppStoreConnect.ReviewSubmissionRelationshipsSubmittedByActor? submittedByActor,
            global::AppStoreConnect.ReviewSubmissionRelationshipsLastUpdatedByActor? lastUpdatedByActor)
        {
            this.App = app;
            this.Items = items;
            this.AppStoreVersionForReview = appStoreVersionForReview;
            this.SubmittedByActor = submittedByActor;
            this.LastUpdatedByActor = lastUpdatedByActor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionRelationships" /> class.
        /// </summary>
        public ReviewSubmissionRelationships()
        {
        }

    }
}