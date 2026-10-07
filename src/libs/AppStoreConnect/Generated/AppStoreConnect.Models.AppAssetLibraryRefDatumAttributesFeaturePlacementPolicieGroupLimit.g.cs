
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesFeaturePlacementPolicieGroupLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupIds")]
        public global::System.Collections.Generic.IList<string>? GroupIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCount")]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesFeaturePlacementPolicieGroupLimit" /> class.
        /// </summary>
        /// <param name="groupIds"></param>
        /// <param name="maxCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesFeaturePlacementPolicieGroupLimit(
            global::System.Collections.Generic.IList<string>? groupIds,
            int? maxCount)
        {
            this.GroupIds = groupIds;
            this.MaxCount = maxCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesFeaturePlacementPolicieGroupLimit" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesFeaturePlacementPolicieGroupLimit()
        {
        }

    }
}