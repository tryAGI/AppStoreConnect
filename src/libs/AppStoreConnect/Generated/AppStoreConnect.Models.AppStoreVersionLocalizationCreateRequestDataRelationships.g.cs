
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsAppStoreVersion AppStoreVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appStoreVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.AppStoreVersionLocalizationCreateRequestDataRelationshipsAppStoreVersion appStoreVersion)
        {
            this.AppStoreVersion = appStoreVersion ?? throw new global::System.ArgumentNullException(nameof(appStoreVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppStoreVersionLocalizationCreateRequestDataRelationships()
        {
        }

    }
}