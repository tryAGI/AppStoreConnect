
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementCommonAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryMediaTypeJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryMediaType? MediaType { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedDate")]
        public global::System.DateTime? LastModifiedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementStateJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryPlacementState? State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stateDetails")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? StateDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementCommonAttributes" /> class.
        /// </summary>
        /// <param name="mediaType"></param>
        /// <param name="placementType"></param>
        /// <param name="placementGroup"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastModifiedDate"></param>
        /// <param name="state"></param>
        /// <param name="stateDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementCommonAttributes(
            global::AppStoreConnect.AppAssetLibraryMediaType? mediaType,
            global::AppStoreConnect.AppAssetLibraryPlacementType2? placementType,
            string? placementGroup,
            global::System.DateTime? createdDate,
            global::System.DateTime? lastModifiedDate,
            global::AppStoreConnect.AppAssetLibraryPlacementState? state,
            global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? stateDetails)
        {
            this.MediaType = mediaType;
            this.PlacementType = placementType;
            this.PlacementGroup = placementGroup;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.State = state;
            this.StateDetails = stateDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementCommonAttributes" /> class.
        /// </summary>
        public AppAssetLibraryPlacementCommonAttributes()
        {
        }

    }
}