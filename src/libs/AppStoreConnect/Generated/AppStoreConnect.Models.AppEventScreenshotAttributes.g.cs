
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventScreenshotAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("imageAsset")]
        public global::AppStoreConnect.ImageAsset? ImageAsset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetToken")]
        public string? AssetToken { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("appEventAssetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventAssetTypeJsonConverter))]
        public global::AppStoreConnect.AppEventAssetType? AppEventAssetType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventScreenshotAttributes" /> class.
        /// </summary>
        /// <param name="fileSize"></param>
        /// <param name="fileName"></param>
        /// <param name="imageAsset"></param>
        /// <param name="assetToken"></param>
        /// <param name="uploadOperations"></param>
        /// <param name="assetDeliveryState"></param>
        /// <param name="appEventAssetType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventScreenshotAttributes(
            int? fileSize,
            string? fileName,
            global::AppStoreConnect.ImageAsset? imageAsset,
            string? assetToken,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? uploadOperations,
            global::AppStoreConnect.AppMediaAssetState? assetDeliveryState,
            global::AppStoreConnect.AppEventAssetType? appEventAssetType)
        {
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.ImageAsset = imageAsset;
            this.AssetToken = assetToken;
            this.UploadOperations = uploadOperations;
            this.AssetDeliveryState = assetDeliveryState;
            this.AppEventAssetType = appEventAssetType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventScreenshotAttributes" /> class.
        /// </summary>
        public AppEventScreenshotAttributes()
        {
        }

    }
}