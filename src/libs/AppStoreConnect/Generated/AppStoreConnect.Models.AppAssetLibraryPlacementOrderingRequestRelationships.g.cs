
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementOrderingRequestRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderedPlacements")]
        public global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacements? OrderedPlacements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementOrderingRequestRelationships" /> class.
        /// </summary>
        /// <param name="orderedPlacements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementOrderingRequestRelationships(
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestRelationshipsOrderedPlacements? orderedPlacements)
        {
            this.OrderedPlacements = orderedPlacements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementOrderingRequestRelationships" /> class.
        /// </summary>
        public AppAssetLibraryPlacementOrderingRequestRelationships()
        {
        }

    }
}