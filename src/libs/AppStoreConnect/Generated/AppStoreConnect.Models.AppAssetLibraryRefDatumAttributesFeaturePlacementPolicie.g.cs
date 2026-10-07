
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesFeaturePlacementPolicie
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementType2JsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryPlacementType2? PlacementType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupLimits")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesFeaturePlacementPolicieGroupLimit>? GroupLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesFeaturePlacementPolicie" /> class.
        /// </summary>
        /// <param name="placementType"></param>
        /// <param name="groupLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesFeaturePlacementPolicie(
            global::AppStoreConnect.AppAssetLibraryPlacementType2? placementType,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesFeaturePlacementPolicieGroupLimit>? groupLimits)
        {
            this.PlacementType = placementType;
            this.GroupLimits = groupLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesFeaturePlacementPolicie" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesFeaturePlacementPolicie()
        {
        }

    }
}