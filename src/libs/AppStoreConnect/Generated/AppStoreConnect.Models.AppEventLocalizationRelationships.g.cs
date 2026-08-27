
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEvent")]
        public global::AppStoreConnect.AppEventLocalizationRelationshipsAppEvent? AppEvent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEventScreenshots")]
        public global::AppStoreConnect.AppEventLocalizationRelationshipsAppEventScreenshots? AppEventScreenshots { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEventVideoClips")]
        public global::AppStoreConnect.AppEventLocalizationRelationshipsAppEventVideoClips? AppEventVideoClips { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appEvent"></param>
        /// <param name="appEventScreenshots"></param>
        /// <param name="appEventVideoClips"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventLocalizationRelationships(
            global::AppStoreConnect.AppEventLocalizationRelationshipsAppEvent? appEvent,
            global::AppStoreConnect.AppEventLocalizationRelationshipsAppEventScreenshots? appEventScreenshots,
            global::AppStoreConnect.AppEventLocalizationRelationshipsAppEventVideoClips? appEventVideoClips)
        {
            this.AppEvent = appEvent;
            this.AppEventScreenshots = appEventScreenshots;
            this.AppEventVideoClips = appEventVideoClips;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventLocalizationRelationships" /> class.
        /// </summary>
        public AppEventLocalizationRelationships()
        {
        }

    }
}