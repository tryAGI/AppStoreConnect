
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipDefaultExperienceRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClip")]
        public global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClip? AppClip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releaseWithAppStoreVersion")]
        public global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion? ReleaseWithAppStoreVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperienceLocalizations")]
        public global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizations? AppClipDefaultExperienceLocalizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipAppStoreReviewDetail")]
        public global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetail? AppClipAppStoreReviewDetail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceRelationships" /> class.
        /// </summary>
        /// <param name="appClip"></param>
        /// <param name="releaseWithAppStoreVersion"></param>
        /// <param name="appClipDefaultExperienceLocalizations"></param>
        /// <param name="appClipAppStoreReviewDetail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipDefaultExperienceRelationships(
            global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClip? appClip,
            global::AppStoreConnect.AppClipDefaultExperienceRelationshipsReleaseWithAppStoreVersion? releaseWithAppStoreVersion,
            global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipDefaultExperienceLocalizations? appClipDefaultExperienceLocalizations,
            global::AppStoreConnect.AppClipDefaultExperienceRelationshipsAppClipAppStoreReviewDetail? appClipAppStoreReviewDetail)
        {
            this.AppClip = appClip;
            this.ReleaseWithAppStoreVersion = releaseWithAppStoreVersion;
            this.AppClipDefaultExperienceLocalizations = appClipDefaultExperienceLocalizations;
            this.AppClipAppStoreReviewDetail = appClipAppStoreReviewDetail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceRelationships" /> class.
        /// </summary>
        public AppClipDefaultExperienceRelationships()
        {
        }

    }
}