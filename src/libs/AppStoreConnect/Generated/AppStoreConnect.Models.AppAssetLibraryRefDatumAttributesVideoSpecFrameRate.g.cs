
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryRefDatumAttributesVideoSpecFrameRate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minFps")]
        public int? MinFps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxFps")]
        public int? MaxFps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesVideoSpecFrameRate" /> class.
        /// </summary>
        /// <param name="minFps"></param>
        /// <param name="maxFps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryRefDatumAttributesVideoSpecFrameRate(
            int? minFps,
            int? maxFps)
        {
            this.MinFps = minFps;
            this.MaxFps = maxFps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryRefDatumAttributesVideoSpecFrameRate" /> class.
        /// </summary>
        public AppAssetLibraryRefDatumAttributesVideoSpecFrameRate()
        {
        }

    }
}