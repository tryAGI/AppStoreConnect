
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundAssetUploadFileUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFileChecksum")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? SourceFileChecksum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFileChecksums")]
        public global::AppStoreConnect.Checksums? SourceFileChecksums { get; set; }

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
        /// Initializes a new instance of the <see cref="BackgroundAssetUploadFileUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="sourceFileChecksums"></param>
        /// <param name="uploaded"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetUploadFileUpdateRequestDataAttributes(
            global::AppStoreConnect.Checksums? sourceFileChecksums,
            bool? uploaded)
        {
            this.SourceFileChecksums = sourceFileChecksums;
            this.Uploaded = uploaded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUploadFileUpdateRequestDataAttributes" /> class.
        /// </summary>
        public BackgroundAssetUploadFileUpdateRequestDataAttributes()
        {
        }

    }
}