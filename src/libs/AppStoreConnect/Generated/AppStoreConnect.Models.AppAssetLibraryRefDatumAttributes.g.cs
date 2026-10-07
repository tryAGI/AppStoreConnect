
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("features")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesFeature>? Features { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementProfileGroups")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesPlacementProfileGroup>? PlacementProfileGroups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageSpecs")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesImageSpec>? ImageSpecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoSpecs")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesVideoSpec>? VideoSpecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placementTypes")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesPlacementType>? PlacementTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayClasses")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesDisplayClasse>? DisplayClasses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributes" /> class.
        /// </summary>
        /// <param name="features"></param>
        /// <param name="placementProfileGroups"></param>
        /// <param name="imageSpecs"></param>
        /// <param name="videoSpecs"></param>
        /// <param name="placementTypes"></param>
        /// <param name="displayClasses"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributes(
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesFeature>? features,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesPlacementProfileGroup>? placementProfileGroups,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesImageSpec>? imageSpecs,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesVideoSpec>? videoSpecs,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesPlacementType>? placementTypes,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesDisplayClasse>? displayClasses)
        {
            this.Features = features;
            this.PlacementProfileGroups = placementProfileGroups;
            this.ImageSpecs = imageSpecs;
            this.VideoSpecs = videoSpecs;
            this.PlacementTypes = placementTypes;
            this.DisplayClasses = displayClasses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributes" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributes()
        {
        }

    }
}