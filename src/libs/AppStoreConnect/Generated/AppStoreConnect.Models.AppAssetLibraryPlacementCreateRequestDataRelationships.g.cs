
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsImage? Image { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsVideo? Video { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEventLocalization")]
        public global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsAppEventLocalization? AppEventLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionLocalization")]
        public global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionLocalization? AppStoreVersionLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageLocalization")]
        public global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsAppCustomProductPageLocalization? AppCustomProductPageLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatmentLocalization")]
        public global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="video"></param>
        /// <param name="appEventLocalization"></param>
        /// <param name="appStoreVersionLocalization"></param>
        /// <param name="appCustomProductPageLocalization"></param>
        /// <param name="appStoreVersionExperimentTreatmentLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementCreateRequestDataRelationships(
            global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsImage? image,
            global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsVideo? video,
            global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsAppEventLocalization? appEventLocalization,
            global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionLocalization? appStoreVersionLocalization,
            global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsAppCustomProductPageLocalization? appCustomProductPageLocalization,
            global::AppStoreConnect.AppAssetLibraryPlacementCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalization)
        {
            this.Image = image;
            this.Video = video;
            this.AppEventLocalization = appEventLocalization;
            this.AppStoreVersionLocalization = appStoreVersionLocalization;
            this.AppCustomProductPageLocalization = appCustomProductPageLocalization;
            this.AppStoreVersionExperimentTreatmentLocalization = appStoreVersionExperimentTreatmentLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppAssetLibraryPlacementCreateRequestDataRelationships()
        {
        }

    }
}