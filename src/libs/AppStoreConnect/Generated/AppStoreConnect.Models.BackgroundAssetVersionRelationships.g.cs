
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundAssetVersionRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundAsset")]
        public global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAsset? BackgroundAsset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalBetaRelease")]
        public global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaRelease? InternalBetaRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalBetaRelease")]
        public global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaRelease? ExternalBetaRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreRelease")]
        public global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreRelease? AppStoreRelease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assetFile")]
        public global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFile? AssetFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifestFile")]
        public global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFile? ManifestFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundAssetUploadFiles")]
        public global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetUploadFiles? BackgroundAssetUploadFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionRelationships" /> class.
        /// </summary>
        /// <param name="backgroundAsset"></param>
        /// <param name="internalBetaRelease"></param>
        /// <param name="externalBetaRelease"></param>
        /// <param name="appStoreRelease"></param>
        /// <param name="assetFile"></param>
        /// <param name="manifestFile"></param>
        /// <param name="backgroundAssetUploadFiles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetVersionRelationships(
            global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAsset? backgroundAsset,
            global::AppStoreConnect.BackgroundAssetVersionRelationshipsInternalBetaRelease? internalBetaRelease,
            global::AppStoreConnect.BackgroundAssetVersionRelationshipsExternalBetaRelease? externalBetaRelease,
            global::AppStoreConnect.BackgroundAssetVersionRelationshipsAppStoreRelease? appStoreRelease,
            global::AppStoreConnect.BackgroundAssetVersionRelationshipsAssetFile? assetFile,
            global::AppStoreConnect.BackgroundAssetVersionRelationshipsManifestFile? manifestFile,
            global::AppStoreConnect.BackgroundAssetVersionRelationshipsBackgroundAssetUploadFiles? backgroundAssetUploadFiles)
        {
            this.BackgroundAsset = backgroundAsset;
            this.InternalBetaRelease = internalBetaRelease;
            this.ExternalBetaRelease = externalBetaRelease;
            this.AppStoreRelease = appStoreRelease;
            this.AssetFile = assetFile;
            this.ManifestFile = manifestFile;
            this.BackgroundAssetUploadFiles = backgroundAssetUploadFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionRelationships" /> class.
        /// </summary>
        public BackgroundAssetVersionRelationships()
        {
        }

    }
}