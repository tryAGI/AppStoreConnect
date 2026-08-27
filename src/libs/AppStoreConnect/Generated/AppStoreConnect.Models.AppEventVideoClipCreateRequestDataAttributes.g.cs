
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppEventVideoClipCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileSize")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewFrameTimeCode")]
        public string? PreviewFrameTimeCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEventAssetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppEventAssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppEventAssetType AppEventAssetType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventVideoClipCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="fileSize"></param>
        /// <param name="fileName"></param>
        /// <param name="appEventAssetType"></param>
        /// <param name="previewFrameTimeCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventVideoClipCreateRequestDataAttributes(
            int fileSize,
            string fileName,
            global::AppStoreConnect.AppEventAssetType appEventAssetType,
            string? previewFrameTimeCode)
        {
            this.FileSize = fileSize;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.PreviewFrameTimeCode = previewFrameTimeCode;
            this.AppEventAssetType = appEventAssetType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventVideoClipCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppEventVideoClipCreateRequestDataAttributes()
        {
        }

    }
}