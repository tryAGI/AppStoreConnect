
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreReviewDetailRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreReviewAttachments")]
        public global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachments? AppStoreReviewAttachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewDetailRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
        /// <param name="appStoreReviewAttachments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreReviewDetailRelationships(
            global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreVersion? appStoreVersion,
            global::AppStoreConnect.AppStoreReviewDetailRelationshipsAppStoreReviewAttachments? appStoreReviewAttachments)
        {
            this.AppStoreVersion = appStoreVersion;
            this.AppStoreReviewAttachments = appStoreReviewAttachments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreReviewDetailRelationships" /> class.
        /// </summary>
        public AppStoreReviewDetailRelationships()
        {
        }

    }
}