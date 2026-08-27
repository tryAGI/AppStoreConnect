
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundAssetUploadFileAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetDeliveryState")]
        public global::AppStoreConnect.AppMediaAssetState? AssetDeliveryState { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetToken")]
        public string? AssetToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileAttributesAssetTypeJsonConverter))]
        public global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType? AssetType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        public long? FileSize { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadOperations")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.DeliveryFileUploadOperation>? UploadOperations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUploadFileAttributes" /> class.
        /// </summary>
        /// <param name="assetDeliveryState"></param>
        /// <param name="assetToken"></param>
        /// <param name="assetType"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
        /// <param name="sourceFileChecksums"></param>
        /// <param name="uploadOperations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetUploadFileAttributes(
            global::AppStoreConnect.AppMediaAssetState? assetDeliveryState,
            string? assetToken,
            global::AppStoreConnect.BackgroundAssetUploadFileAttributesAssetType? assetType,
            string? fileName,
            long? fileSize,
            global::AppStoreConnect.Checksums? sourceFileChecksums,
            global::System.Collections.Generic.IList<global::AppStoreConnect.DeliveryFileUploadOperation>? uploadOperations)
        {
            this.AssetDeliveryState = assetDeliveryState;
            this.AssetToken = assetToken;
            this.AssetType = assetType;
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.SourceFileChecksums = sourceFileChecksums;
            this.UploadOperations = uploadOperations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUploadFileAttributes" /> class.
        /// </summary>
        public BackgroundAssetUploadFileAttributes()
        {
        }

    }
}