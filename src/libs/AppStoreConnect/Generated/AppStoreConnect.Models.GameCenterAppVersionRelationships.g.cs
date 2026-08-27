
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GameCenterAppVersionRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatibilityVersions")]
        public global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersions? CompatibilityVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        public global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersion? AppStoreVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAppVersionRelationships" /> class.
        /// </summary>
        /// <param name="compatibilityVersions"></param>
        /// <param name="appStoreVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAppVersionRelationships(
            global::AppStoreConnect.GameCenterAppVersionRelationshipsCompatibilityVersions? compatibilityVersions,
            global::AppStoreConnect.GameCenterAppVersionRelationshipsAppStoreVersion? appStoreVersion)
        {
            this.CompatibilityVersions = compatibilityVersions;
            this.AppStoreVersion = appStoreVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAppVersionRelationships" /> class.
        /// </summary>
        public GameCenterAppVersionRelationships()
        {
        }

    }
}