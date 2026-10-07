
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryImageCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetLibrary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibrary AssetLibrary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placements")]
        public global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacements? Placements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryImageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="assetLibrary"></param>
        /// <param name="placements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryImageCreateRequestDataRelationships(
            global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsAssetLibrary assetLibrary,
            global::AppStoreConnect.AppAssetLibraryImageCreateRequestDataRelationshipsPlacements? placements)
        {
            this.AssetLibrary = assetLibrary ?? throw new global::System.ArgumentNullException(nameof(assetLibrary));
            this.Placements = placements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryImageCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppAssetLibraryImageCreateRequestDataRelationships()
        {
        }

    }
}