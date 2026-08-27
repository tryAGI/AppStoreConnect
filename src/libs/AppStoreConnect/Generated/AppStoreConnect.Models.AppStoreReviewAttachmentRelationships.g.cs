
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreReviewAttachmentRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreReviewDetail")]
        public global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetail? AppStoreReviewDetail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewAttachmentRelationships" /> class.
        /// </summary>
        /// <param name="appStoreReviewDetail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreReviewAttachmentRelationships(
            global::AppStoreConnect.AppStoreReviewAttachmentRelationshipsAppStoreReviewDetail? appStoreReviewDetail)
        {
            this.AppStoreReviewDetail = appStoreReviewDetail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewAttachmentRelationships" /> class.
        /// </summary>
        public AppStoreReviewAttachmentRelationships()
        {
        }

    }
}