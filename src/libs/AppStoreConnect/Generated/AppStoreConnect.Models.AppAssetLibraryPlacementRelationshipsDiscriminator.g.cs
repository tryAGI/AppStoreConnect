
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementRelationshipsDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaTypeJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType? MediaType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementRelationshipsDiscriminator" /> class.
        /// </summary>
        /// <param name="mediaType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementRelationshipsDiscriminator(
            global::AppStoreConnect.AppAssetLibraryPlacementRelationshipsDiscriminatorMediaType? mediaType)
        {
            this.MediaType = mediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementRelationshipsDiscriminator" /> class.
        /// </summary>
        public AppAssetLibraryPlacementRelationshipsDiscriminator()
        {
        }

    }
}