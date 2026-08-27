
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseImageAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("assetToken")]
        public string? AssetToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageAsset")]
        public global::AppStoreConnect.ImageAsset? ImageAsset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadOperations")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? UploadOperations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InAppPurchaseImageAttributesStateJsonConverter))]
        public global::AppStoreConnect.InAppPurchaseImageAttributesState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseImageAttributes" /> class.
        /// </summary>
        /// <param name="fileSize"></param>
        /// <param name="fileName"></param>
        /// <param name="sourceFileChecksum"></param>
        /// <param name="assetToken"></param>
        /// <param name="imageAsset"></param>
        /// <param name="uploadOperations"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseImageAttributes(
            int? fileSize,
            string? fileName,
            string? sourceFileChecksum,
            string? assetToken,
            global::AppStoreConnect.ImageAsset? imageAsset,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? uploadOperations,
            global::AppStoreConnect.InAppPurchaseImageAttributesState? state)
        {
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.SourceFileChecksum = sourceFileChecksum;
            this.AssetToken = assetToken;
            this.ImageAsset = imageAsset;
            this.UploadOperations = uploadOperations;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseImageAttributes" /> class.
        /// </summary>
        public InAppPurchaseImageAttributes()
        {
        }

    }
}