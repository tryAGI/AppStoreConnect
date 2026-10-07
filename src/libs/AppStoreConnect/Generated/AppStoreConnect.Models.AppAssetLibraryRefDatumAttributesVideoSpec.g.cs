
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesVideoSpec
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specId")]
        public string? SpecId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortName")]
        public string? ShortName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public global::AppStoreConnect.AppAssetLibraryRefDatumAttributesVideoSpecDimensions? Dimensions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatiblePlacementTypes")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementType2>? CompatiblePlacementTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameRates")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesVideoSpecFrameRate>? FrameRates { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public global::AppStoreConnect.AppAssetLibraryRefDatumAttributesVideoSpecDuration? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioRequired")]
        public bool? AudioRequired { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileExtensions")]
        public global::System.Collections.Generic.IList<string>? FileExtensions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFileSize")]
        public long? MaxFileSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeTypes")]
        public global::System.Collections.Generic.IList<string>? MimeTypes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("universalAsset")]
        public bool? UniversalAsset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesVideoSpec" /> class.
        /// </summary>
        /// <param name="specId"></param>
        /// <param name="shortName"></param>
        /// <param name="dimensions"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="compatiblePlacementTypes"></param>
        /// <param name="frameRates"></param>
        /// <param name="duration"></param>
        /// <param name="audioRequired"></param>
        /// <param name="fileExtensions"></param>
        /// <param name="maxFileSize"></param>
        /// <param name="mimeTypes"></param>
        /// <param name="universalAsset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesVideoSpec(
            string? specId,
            string? shortName,
            global::AppStoreConnect.AppAssetLibraryRefDatumAttributesVideoSpecDimensions? dimensions,
            string? aspectRatio,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementType2>? compatiblePlacementTypes,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDatumAttributesVideoSpecFrameRate>? frameRates,
            global::AppStoreConnect.AppAssetLibraryRefDatumAttributesVideoSpecDuration? duration,
            bool? audioRequired,
            global::System.Collections.Generic.IList<string>? fileExtensions,
            long? maxFileSize,
            global::System.Collections.Generic.IList<string>? mimeTypes,
            bool? universalAsset)
        {
            this.SpecId = specId;
            this.ShortName = shortName;
            this.Dimensions = dimensions;
            this.AspectRatio = aspectRatio;
            this.CompatiblePlacementTypes = compatiblePlacementTypes;
            this.FrameRates = frameRates;
            this.Duration = duration;
            this.AudioRequired = audioRequired;
            this.FileExtensions = fileExtensions;
            this.MaxFileSize = maxFileSize;
            this.MimeTypes = mimeTypes;
            this.UniversalAsset = universalAsset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesVideoSpec" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesVideoSpec()
        {
        }

    }
}