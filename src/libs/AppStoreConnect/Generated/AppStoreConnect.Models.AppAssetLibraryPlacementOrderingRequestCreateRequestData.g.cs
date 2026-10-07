
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementOrderingRequestCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementOrderingRequestCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementOrderingRequestCreateRequestData" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementOrderingRequestCreateRequestData(
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataType type,
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataAttributes? attributes,
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestDataRelationships? relationships)
        {
            this.Type = type;
            this.Attributes = attributes;
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementOrderingRequestCreateRequestData" /> class.
        /// </summary>
        public AppAssetLibraryPlacementOrderingRequestCreateRequestData()
        {
        }

    }
}