
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildUploadFileCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataAttributesAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType AssetType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("uti")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BuildUploadFileCreateRequestDataAttributesUtiJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti Uti { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadFileCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="assetType"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
        /// <param name="uti"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildUploadFileCreateRequestDataAttributes(
            global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesAssetType assetType,
            string fileName,
            long fileSize,
            global::AppStoreConnect.BuildUploadFileCreateRequestDataAttributesUti uti)
        {
            this.AssetType = assetType;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileSize = fileSize;
            this.Uti = uti;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadFileCreateRequestDataAttributes" /> class.
        /// </summary>
        public BuildUploadFileCreateRequestDataAttributes()
        {
        }

    }
}