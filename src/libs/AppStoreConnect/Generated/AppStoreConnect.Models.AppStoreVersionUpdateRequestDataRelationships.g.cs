
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionUpdateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuild? Build { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperience")]
        public global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperience? AppClipDefaultExperience { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="build"></param>
        /// <param name="appClipDefaultExperience"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionUpdateRequestDataRelationships(
            global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsBuild? build,
            global::AppStoreConnect.AppStoreVersionUpdateRequestDataRelationshipsAppClipDefaultExperience? appClipDefaultExperience)
        {
            this.Build = build;
            this.AppClipDefaultExperience = appClipDefaultExperience;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionUpdateRequestDataRelationships" /> class.
        /// </summary>
        public AppStoreVersionUpdateRequestDataRelationships()
        {
        }

    }
}