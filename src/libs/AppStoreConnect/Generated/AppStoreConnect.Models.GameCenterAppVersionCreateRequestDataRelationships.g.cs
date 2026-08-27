
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterAppVersionCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.GameCenterAppVersionCreateRequestDataRelationshipsAppStoreVersion AppStoreVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAppVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GameCenterAppVersionCreateRequestDataRelationships(
            global::AppStoreConnect.GameCenterAppVersionCreateRequestDataRelationshipsAppStoreVersion appStoreVersion)
        {
            this.AppStoreVersion = appStoreVersion ?? throw new global::System.ArgumentNullException(nameof(appStoreVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameCenterAppVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        public GameCenterAppVersionCreateRequestDataRelationships()
        {
        }

    }
}