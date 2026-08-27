
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAppStoreReviewDetailRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperience")]
        public global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperience? AppClipDefaultExperience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAppStoreReviewDetailRelationships" /> class.
        /// </summary>
        /// <param name="appClipDefaultExperience"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAppStoreReviewDetailRelationships(
            global::AppStoreConnect.AppClipAppStoreReviewDetailRelationshipsAppClipDefaultExperience? appClipDefaultExperience)
        {
            this.AppClipDefaultExperience = appClipDefaultExperience;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAppStoreReviewDetailRelationships" /> class.
        /// </summary>
        public AppClipAppStoreReviewDetailRelationships()
        {
        }

    }
}