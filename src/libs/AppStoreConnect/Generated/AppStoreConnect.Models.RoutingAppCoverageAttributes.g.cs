
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RoutingAppCoverageAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadOperations")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? UploadOperations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetDeliveryState")]
        public global::AppStoreConnect.AppMediaAssetState? AssetDeliveryState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingAppCoverageAttributes" /> class.
        /// </summary>
        /// <param name="fileSize"></param>
        /// <param name="fileName"></param>
        /// <param name="sourceFileChecksum"></param>
        /// <param name="uploadOperations"></param>
        /// <param name="assetDeliveryState"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutingAppCoverageAttributes(
            int? fileSize,
            string? fileName,
            string? sourceFileChecksum,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UploadOperation>? uploadOperations,
            global::AppStoreConnect.AppMediaAssetState? assetDeliveryState)
        {
            this.FileSize = fileSize;
            this.FileName = fileName;
            this.SourceFileChecksum = sourceFileChecksum;
            this.UploadOperations = uploadOperations;
            this.AssetDeliveryState = assetDeliveryState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingAppCoverageAttributes" /> class.
        /// </summary>
        public RoutingAppCoverageAttributes()
        {
        }

    }
}