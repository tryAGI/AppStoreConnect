
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::AppStoreConnect.AppAssetLibraryRelationshipsImages? Images { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videos")]
        public global::AppStoreConnect.AppAssetLibraryRelationshipsVideos? Videos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRelationships" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="videos"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRelationships(
            global::AppStoreConnect.AppAssetLibraryRelationshipsImages? images,
            global::AppStoreConnect.AppAssetLibraryRelationshipsVideos? videos)
        {
            this.Images = images;
            this.Videos = videos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRelationships" /> class.
        /// </summary>
        public AppAssetLibraryRelationships()
        {
        }

    }
}