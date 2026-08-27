
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundAssetUploadFileCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BackgroundAssetUploadFileCreateRequestDataAttributesAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BackgroundAssetUploadFileCreateRequestDataAttributesAssetType AssetType { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUploadFileCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="assetType"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetUploadFileCreateRequestDataAttributes(
            global::AppStoreConnect.BackgroundAssetUploadFileCreateRequestDataAttributesAssetType assetType,
            string fileName,
            long fileSize)
        {
            this.AssetType = assetType;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileSize = fileSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUploadFileCreateRequestDataAttributes" /> class.
        /// </summary>
        public BackgroundAssetUploadFileCreateRequestDataAttributes()
        {
        }

    }
}