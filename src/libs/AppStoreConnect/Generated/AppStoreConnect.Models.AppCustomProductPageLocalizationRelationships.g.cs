
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCustomProductPageLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageVersion")]
        public global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersion? AppCustomProductPageVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appScreenshotSets")]
        public global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSets? AppScreenshotSets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPreviewSets")]
        public global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSets? AppPreviewSets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchKeywords")]
        public global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywords? SearchKeywords { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPageVersion"></param>
        /// <param name="appScreenshotSets"></param>
        /// <param name="appPreviewSets"></param>
        /// <param name="searchKeywords"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageLocalizationRelationships(
            global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersion? appCustomProductPageVersion,
            global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppScreenshotSets? appScreenshotSets,
            global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsAppPreviewSets? appPreviewSets,
            global::AppStoreConnect.AppCustomProductPageLocalizationRelationshipsSearchKeywords? searchKeywords)
        {
            this.AppCustomProductPageVersion = appCustomProductPageVersion;
            this.AppScreenshotSets = appScreenshotSets;
            this.AppPreviewSets = appPreviewSets;
            this.SearchKeywords = searchKeywords;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationRelationships" /> class.
        /// </summary>
        public AppCustomProductPageLocalizationRelationships()
        {
        }

    }
}