
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreReviewAttachmentCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreReviewDetail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetail AppStoreReviewDetail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewAttachmentCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreReviewDetail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreReviewAttachmentCreateRequestDataRelationships(
            global::AppStoreConnect.AppStoreReviewAttachmentCreateRequestDataRelationshipsAppStoreReviewDetail appStoreReviewDetail)
        {
            this.AppStoreReviewDetail = appStoreReviewDetail ?? throw new global::System.ArgumentNullException(nameof(appStoreReviewDetail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewAttachmentCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppStoreReviewAttachmentCreateRequestDataRelationships()
        {
        }

    }
}