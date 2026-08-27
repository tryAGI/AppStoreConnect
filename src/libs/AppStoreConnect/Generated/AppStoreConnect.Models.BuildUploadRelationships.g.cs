
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildUploadRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public global::AppStoreConnect.BuildUploadRelationshipsBuild? Build { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetFile")]
        public global::AppStoreConnect.BuildUploadRelationshipsAssetFile? AssetFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetDescriptionFile")]
        public global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFile? AssetDescriptionFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetSpiFile")]
        public global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFile? AssetSpiFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildUploadFiles")]
        public global::AppStoreConnect.BuildUploadRelationshipsBuildUploadFiles? BuildUploadFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadRelationships" /> class.
        /// </summary>
        /// <param name="build"></param>
        /// <param name="assetFile"></param>
        /// <param name="assetDescriptionFile"></param>
        /// <param name="assetSpiFile"></param>
        /// <param name="buildUploadFiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildUploadRelationships(
            global::AppStoreConnect.BuildUploadRelationshipsBuild? build,
            global::AppStoreConnect.BuildUploadRelationshipsAssetFile? assetFile,
            global::AppStoreConnect.BuildUploadRelationshipsAssetDescriptionFile? assetDescriptionFile,
            global::AppStoreConnect.BuildUploadRelationshipsAssetSpiFile? assetSpiFile,
            global::AppStoreConnect.BuildUploadRelationshipsBuildUploadFiles? buildUploadFiles)
        {
            this.Build = build;
            this.AssetFile = assetFile;
            this.AssetDescriptionFile = assetDescriptionFile;
            this.AssetSpiFile = assetSpiFile;
            this.BuildUploadFiles = buildUploadFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadRelationships" /> class.
        /// </summary>
        public BuildUploadRelationships()
        {
        }

    }
}