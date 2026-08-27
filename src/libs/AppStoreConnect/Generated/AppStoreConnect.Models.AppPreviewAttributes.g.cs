
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPreviewAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public int? FileSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceFileChecksum")]
        public string? SourceFileChecksum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewFrameTimeCode")]
        public string? PreviewFrameTimeCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUrl")]
        public string? VideoUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewFrameImage")]
        public global::AppStoreConnect.PreviewFrameImage? PreviewFrameImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewImage")]
        public global::AppStoreConnect.ImageAsset? PreviewImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadOperations")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? UploadOperations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetDeliveryState")]
        public global::AppStoreConnect.AppMediaAssetState? AssetDeliveryState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoDeliveryState")]
        public global::AppStoreConnect.AppMediaVideoState? VideoDeliveryState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewAttributes" /> class.
        /// </summary>
        /// <param name="fileSize"></param>
        /// <param name="fileName"></param>
        /// <param name="sourceFileChecksum"></param>
        /// <param name="previewFrameTimeCode"></param>
        /// <param name="mimeType"></param>
        /// <param name="videoUrl"></param>
        /// <param name="previewFrameImage"></param>
        /// <param name="previewImage"></param>
        /// <param name="uploadOperations"></param>
        /// <param name="assetDeliveryState"></param>
        /// <param name="videoDeliveryState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPreviewAttributes(
            int? fileSize,
            string? fileName,
            string? sourceFileChecksum,
            string? previewFrameTimeCode,
            string? mimeType,
            string? videoUrl,
            global::AppStoreConnect.PreviewFrameImage? previewFrameImage,
            global::AppStoreConnect.ImageAsset? previewImage,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? uploadOperations,
            global::AppStoreConnect.AppMediaAssetState? assetDeliveryState,
            global::AppStoreConnect.AppMediaVideoState? videoDeliveryState)
        {
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.SourceFileChecksum = sourceFileChecksum;
            this.PreviewFrameTimeCode = previewFrameTimeCode;
            this.MimeType = mimeType;
            this.VideoUrl = videoUrl;
            this.PreviewFrameImage = previewFrameImage;
            this.PreviewImage = previewImage;
            this.UploadOperations = uploadOperations;
            this.AssetDeliveryState = assetDeliveryState;
            this.VideoDeliveryState = videoDeliveryState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewAttributes" /> class.
        /// </summary>
        public AppPreviewAttributes()
        {
        }

    }
}