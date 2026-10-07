
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryVideoRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placements")]
        public global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacements? Placements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryVideoRelationships" /> class.
        /// </summary>
        /// <param name="placements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryVideoRelationships(
            global::AppStoreConnect.AppAssetLibraryVideoRelationshipsPlacements? placements)
        {
            this.Placements = placements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryVideoRelationships" /> class.
        /// </summary>
        public AppAssetLibraryVideoRelationships()
        {
        }

    }
}