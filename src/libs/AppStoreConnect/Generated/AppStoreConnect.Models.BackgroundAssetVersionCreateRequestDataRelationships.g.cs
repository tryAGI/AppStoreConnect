
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundAssetVersionCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundAsset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BackgroundAssetVersionCreateRequestDataRelationshipsBackgroundAsset BackgroundAsset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="backgroundAsset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetVersionCreateRequestDataRelationships(
            global::AppStoreConnect.BackgroundAssetVersionCreateRequestDataRelationshipsBackgroundAsset backgroundAsset)
        {
            this.BackgroundAsset = backgroundAsset ?? throw new global::System.ArgumentNullException(nameof(backgroundAsset));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        public BackgroundAssetVersionCreateRequestDataRelationships()
        {
        }

    }
}