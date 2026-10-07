
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesFeature
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("featureId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryFeatureJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryFeature? FeatureId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementPolicies")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesFeaturePlacementPolicie>? PlacementPolicies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesFeature" /> class.
        /// </summary>
        /// <param name="featureId"></param>
        /// <param name="placementPolicies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesFeature(
            global::AppStoreConnect.AppAssetLibraryFeature? featureId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesFeaturePlacementPolicie>? placementPolicies)
        {
            this.FeatureId = featureId;
            this.PlacementPolicies = placementPolicies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesFeature" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesFeature()
        {
        }

    }
}