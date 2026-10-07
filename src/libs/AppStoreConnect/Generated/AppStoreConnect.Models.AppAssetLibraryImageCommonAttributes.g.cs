
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAssetLibraryImageCommonAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetCategoryJsonConverter))]
        public global::AppStoreConnect.AppAssetLibraryAssetCategory? Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedDate")]
        public global::System.DateTime? LastModifiedDate { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("imageAsset")]
        public global::AppStoreConnect.ImageAsset? ImageAsset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specId")]
        public string? SpecId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAssetLibraryAssetStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppAssetLibraryAssetState State { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stateDetails")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? StateDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryImageCommonAttributes" /> class.
        /// </summary>
        /// <param name="state"></param>
        /// <param name="category"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastModifiedDate"></param>
        /// <param name="fileName"></param>
        /// <param name="fileSize"></param>
        /// <param name="imageAsset"></param>
        /// <param name="referenceName"></param>
        /// <param name="specId"></param>
        /// <param name="stateDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAssetLibraryImageCommonAttributes(
            global::AppStoreConnect.AppAssetLibraryAssetState state,
            global::AppStoreConnect.AppAssetLibraryAssetCategory? category,
            global::System.DateTime? createdDate,
            global::System.DateTime? lastModifiedDate,
            string? fileName,
            long? fileSize,
            global::AppStoreConnect.ImageAsset? imageAsset,
            string? referenceName,
            string? specId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.StateDetail>? stateDetails)
        {
            this.Category = category;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.ImageAsset = imageAsset;
            this.ReferenceName = referenceName;
            this.SpecId = specId;
            this.State = state;
            this.StateDetails = stateDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAssetLibraryImageCommonAttributes" /> class.
        /// </summary>
        public AppAssetLibraryImageCommonAttributes()
        {
        }

    }
}