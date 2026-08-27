
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiArtifactAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CiArtifactAttributesFileTypeJsonConverter))]
        public global::AppStoreConnect.CiArtifactAttributesFileType? FileType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public int? FileSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiArtifactAttributes" /> class.
        /// </summary>
        /// <param name="fileType"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
        /// <param name="downloadUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiArtifactAttributes(
            global::AppStoreConnect.CiArtifactAttributesFileType? fileType,
            string? fileName,
            int? fileSize,
            string? downloadUrl)
        {
            this.FileType = fileType;
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.DownloadUrl = downloadUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiArtifactAttributes" /> class.
        /// </summary>
        public CiArtifactAttributes()
        {
        }

    }
}