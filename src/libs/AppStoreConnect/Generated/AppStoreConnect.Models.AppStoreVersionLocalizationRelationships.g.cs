
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppStoreVersionLocalizationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appScreenshotSets")]
        public global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSets? AppScreenshotSets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPreviewSets")]
        public global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSets? AppPreviewSets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchKeywords")]
        public global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywords? SearchKeywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
        /// <param name="appScreenshotSets"></param>
        /// <param name="appPreviewSets"></param>
        /// <param name="searchKeywords"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionLocalizationRelationships(
            global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppStoreVersion? appStoreVersion,
            global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppScreenshotSets? appScreenshotSets,
            global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsAppPreviewSets? appPreviewSets,
            global::AppStoreConnect.AppStoreVersionLocalizationRelationshipsSearchKeywords? searchKeywords)
        {
            this.AppStoreVersion = appStoreVersion;
            this.AppScreenshotSets = appScreenshotSets;
            this.AppPreviewSets = appPreviewSets;
            this.SearchKeywords = searchKeywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionLocalizationRelationships" /> class.
        /// </summary>
        public AppStoreVersionLocalizationRelationships()
        {
        }

    }
}