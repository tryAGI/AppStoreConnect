
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryVideoCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppAssetLibraryAssetCategory Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FileSize { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryVideoCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
        /// <param name="previewFrameTimeCode"></param>
        /// <param name="referenceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryVideoCreateRequestDataAttributes(
            global::AppStoreConnect.AppAssetLibraryAssetCategory category,
            string fileName,
            long fileSize,
            string? previewFrameTimeCode,
            string? referenceName)
        {
            this.Category = category;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileSize = fileSize;
            this.PreviewFrameTimeCode = previewFrameTimeCode;
            this.ReferenceName = referenceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryVideoCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppAssetLibraryVideoCreateRequestDataAttributes()
        {
        }

    }
}