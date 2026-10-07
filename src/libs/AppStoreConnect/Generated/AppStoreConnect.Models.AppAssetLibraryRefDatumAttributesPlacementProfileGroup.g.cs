
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesPlacementProfileGroup
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementProfileGroupId")]
        public string? PlacementProfileGroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementPlatformJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryPlacementPlatform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayClassId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryDisplayClassJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryDisplayClass? DisplayClassId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesPlacementProfileGroup" /> class.
        /// </summary>
        /// <param name="placementProfileGroupId"></param>
        /// <param name="platform"></param>
        /// <param name="displayClassId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesPlacementProfileGroup(
            string? placementProfileGroupId,
            global::AppStoreConnect.AppAssetLibraryPlacementPlatform? platform,
            global::AppStoreConnect.AppAssetLibraryDisplayClass? displayClassId)
        {
            this.PlacementProfileGroupId = placementProfileGroupId;
            this.Platform = platform;
            this.DisplayClassId = displayClassId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesPlacementProfileGroup" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesPlacementProfileGroup()
        {
        }

    }
}