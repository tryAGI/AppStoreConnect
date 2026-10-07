
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderedPlacements")]
        public global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacements? OrderedPlacements { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionLocalization")]
        public global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalization? AppStoreVersionLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageLocalization")]
        public global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalization? AppCustomProductPageLocalization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionExperimentTreatmentLocalization")]
        public global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="orderedPlacements"></param>
        /// <param name="appStoreVersionLocalization"></param>
        /// <param name="appCustomProductPageLocalization"></param>
        /// <param name="appStoreVersionExperimentTreatmentLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships(
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsOrderedPlacements? orderedPlacements,
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionLocalization? appStoreVersionLocalization,
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppCustomProductPageLocalization? appCustomProductPageLocalization,
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationshipsAppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalization)
        {
            this.OrderedPlacements = orderedPlacements;
            this.AppStoreVersionLocalization = appStoreVersionLocalization;
            this.AppCustomProductPageLocalization = appCustomProductPageLocalization;
            this.AppStoreVersionExperimentTreatmentLocalization = appStoreVersionExperimentTreatmentLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships()
        {
        }

    }
}