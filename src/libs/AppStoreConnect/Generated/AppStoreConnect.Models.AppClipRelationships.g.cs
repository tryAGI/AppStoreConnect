
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.AppClipRelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipDefaultExperiences")]
        public global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiences? AppClipDefaultExperiences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appClipAdvancedExperiences")]
        public global::AppStoreConnect.AppClipRelationshipsAppClipAdvancedExperiences? AppClipAdvancedExperiences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="appClipDefaultExperiences"></param>
        /// <param name="appClipAdvancedExperiences"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipRelationships(
            global::AppStoreConnect.AppClipRelationshipsApp? app,
            global::AppStoreConnect.AppClipRelationshipsAppClipDefaultExperiences? appClipDefaultExperiences,
            global::AppStoreConnect.AppClipRelationshipsAppClipAdvancedExperiences? appClipAdvancedExperiences)
        {
            this.App = app;
            this.AppClipDefaultExperiences = appClipDefaultExperiences;
            this.AppClipAdvancedExperiences = appClipAdvancedExperiences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipRelationships" /> class.
        /// </summary>
        public AppClipRelationships()
        {
        }

    }
}