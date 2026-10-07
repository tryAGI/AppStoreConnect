
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesPlacementType
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementTypeId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementType2JsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryPlacementType2? PlacementTypeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acceptsAssetCategories")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryAssetCategory>? AcceptsAssetCategories { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specMappings")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesPlacementTypeSpecMapping>? SpecMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesPlacementType" /> class.
        /// </summary>
        /// <param name="placementTypeId"></param>
        /// <param name="acceptsAssetCategories"></param>
        /// <param name="specMappings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesPlacementType(
            global::AppStoreConnect.AppAssetLibraryPlacementType2? placementTypeId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryAssetCategory>? acceptsAssetCategories,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesPlacementTypeSpecMapping>? specMappings)
        {
            this.PlacementTypeId = placementTypeId;
            this.AcceptsAssetCategories = acceptsAssetCategories;
            this.SpecMappings = specMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesPlacementType" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesPlacementType()
        {
        }

    }
}