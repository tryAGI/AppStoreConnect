
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipDefaultExperienceCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClip")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClip AppClip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("releaseWithAppStoreVersion")]
        public global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion? ReleaseWithAppStoreVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperienceTemplate")]
        public global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplate? AppClipDefaultExperienceTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appClip"></param>
        /// <param name="releaseWithAppStoreVersion"></param>
        /// <param name="appClipDefaultExperienceTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipDefaultExperienceCreateRequestDataRelationships(
            global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClip appClip,
            global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsReleaseWithAppStoreVersion? releaseWithAppStoreVersion,
            global::AppStoreConnect.AppClipDefaultExperienceCreateRequestDataRelationshipsAppClipDefaultExperienceTemplate? appClipDefaultExperienceTemplate)
        {
            this.AppClip = appClip ?? throw new global::System.ArgumentNullException(nameof(appClip));
            this.ReleaseWithAppStoreVersion = releaseWithAppStoreVersion;
            this.AppClipDefaultExperienceTemplate = appClipDefaultExperienceTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppClipDefaultExperienceCreateRequestDataRelationships()
        {
        }

    }
}