
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("placementGroup")]
        public string? PlacementGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="placementType"></param>
        /// <param name="placementGroup"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementCreateRequestDataAttributes(
            global::AppStoreConnect.AppAssetLibraryPlacementType2? placementType,
            string? placementGroup)
        {
            this.PlacementType = placementType;
            this.PlacementGroup = placementGroup;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppAssetLibraryPlacementCreateRequestDataAttributes()
        {
        }

    }
}