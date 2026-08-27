
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackgroundAssetRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.BackgroundAssetRelationshipsApp? App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.BackgroundAssetRelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalBetaVersion")]
        public global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersion? InternalBetaVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalBetaVersion")]
        public global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersion? ExternalBetaVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="versions"></param>
        /// <param name="appStoreVersion"></param>
        /// <param name="internalBetaVersion"></param>
        /// <param name="externalBetaVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetRelationships(
            global::AppStoreConnect.BackgroundAssetRelationshipsApp? app,
            global::AppStoreConnect.BackgroundAssetRelationshipsVersions? versions,
            global::AppStoreConnect.BackgroundAssetRelationshipsAppStoreVersion? appStoreVersion,
            global::AppStoreConnect.BackgroundAssetRelationshipsInternalBetaVersion? internalBetaVersion,
            global::AppStoreConnect.BackgroundAssetRelationshipsExternalBetaVersion? externalBetaVersion)
        {
            this.App = app;
            this.Versions = versions;
            this.AppStoreVersion = appStoreVersion;
            this.InternalBetaVersion = internalBetaVersion;
            this.ExternalBetaVersion = externalBetaVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetRelationships" /> class.
        /// </summary>
        public BackgroundAssetRelationships()
        {
        }

    }
}