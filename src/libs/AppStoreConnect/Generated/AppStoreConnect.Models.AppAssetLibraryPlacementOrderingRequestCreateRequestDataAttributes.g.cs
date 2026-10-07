
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementGroup")]
        public string? PlacementGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="placementGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes(
            string? placementGroup)
        {
            this.PlacementGroup = placementGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes()
        {
        }

    }
}