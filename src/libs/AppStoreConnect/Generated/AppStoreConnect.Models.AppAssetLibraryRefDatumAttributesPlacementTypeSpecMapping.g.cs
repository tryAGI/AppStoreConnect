
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesPlacementTypeSpecMapping
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementGroupId")]
        public string? PlacementGroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specs")]
        public global::System.Collections.Generic.IList<string>? Specs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesPlacementTypeSpecMapping" /> class.
        /// </summary>
        /// <param name="placementGroupId"></param>
        /// <param name="specs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesPlacementTypeSpecMapping(
            string? placementGroupId,
            global::System.Collections.Generic.IList<string>? specs)
        {
            this.PlacementGroupId = placementGroupId;
            this.Specs = specs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesPlacementTypeSpecMapping" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesPlacementTypeSpecMapping()
        {
        }

    }
}