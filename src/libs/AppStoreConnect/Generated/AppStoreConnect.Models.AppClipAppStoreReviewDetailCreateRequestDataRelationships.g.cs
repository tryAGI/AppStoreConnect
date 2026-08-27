
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAppStoreReviewDetailCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipAppStoreReviewDetailCreateRequestDataRelationshipsAppClipDefaultExperience AppClipDefaultExperience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAppStoreReviewDetailCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appClipDefaultExperience"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAppStoreReviewDetailCreateRequestDataRelationships(
            global::AppStoreConnect.AppClipAppStoreReviewDetailCreateRequestDataRelationshipsAppClipDefaultExperience appClipDefaultExperience)
        {
            this.AppClipDefaultExperience = appClipDefaultExperience ?? throw new global::System.ArgumentNullException(nameof(appClipDefaultExperience));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAppStoreReviewDetailCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppClipAppStoreReviewDetailCreateRequestDataRelationships()
        {
        }

    }
}