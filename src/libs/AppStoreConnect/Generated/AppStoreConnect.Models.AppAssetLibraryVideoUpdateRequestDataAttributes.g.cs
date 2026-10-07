
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryVideoUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewFrameTimeCode")]
        public string? PreviewFrameTimeCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded")]
        public bool? Uploaded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryVideoUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="previewFrameTimeCode"></param>
        /// <param name="referenceName"></param>
        /// <param name="uploaded"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryVideoUpdateRequestDataAttributes(
            bool? archived,
            string? previewFrameTimeCode,
            string? referenceName,
            bool? uploaded)
        {
            this.Archived = archived;
            this.PreviewFrameTimeCode = previewFrameTimeCode;
            this.ReferenceName = referenceName;
            this.Uploaded = uploaded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryVideoUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppAssetLibraryVideoUpdateRequestDataAttributes()
        {
        }

    }
}