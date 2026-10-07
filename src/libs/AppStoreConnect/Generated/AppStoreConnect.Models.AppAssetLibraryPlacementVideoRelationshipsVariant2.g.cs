
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryPlacementVideoRelationshipsVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2Video? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementVideoRelationshipsVariant2" /> class.
        /// </summary>
        /// <param name="video"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryPlacementVideoRelationshipsVariant2(
            global::AppStoreConnect.AppAssetLibraryPlacementVideoRelationshipsVariant2Video? video)
        {
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryPlacementVideoRelationshipsVariant2" /> class.
        /// </summary>
        public AppAssetLibraryPlacementVideoRelationshipsVariant2()
        {
        }

    }
}