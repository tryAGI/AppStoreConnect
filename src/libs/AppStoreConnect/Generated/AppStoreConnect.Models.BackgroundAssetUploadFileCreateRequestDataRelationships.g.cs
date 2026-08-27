
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundAssetUploadFileCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundAssetVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BackgroundAssetUploadFileCreateRequestDataRelationshipsBackgroundAssetVersion BackgroundAssetVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUploadFileCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="backgroundAssetVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetUploadFileCreateRequestDataRelationships(
            global::AppStoreConnect.BackgroundAssetUploadFileCreateRequestDataRelationshipsBackgroundAssetVersion backgroundAssetVersion)
        {
            this.BackgroundAssetVersion = backgroundAssetVersion ?? throw new global::System.ArgumentNullException(nameof(backgroundAssetVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUploadFileCreateRequestDataRelationships" /> class.
        /// </summary>
        public BackgroundAssetUploadFileCreateRequestDataRelationships()
        {
        }

    }
}