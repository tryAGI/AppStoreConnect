
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventScreenshotRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEventLocalization")]
        public global::AppStoreConnect.AppEventScreenshotRelationshipsAppEventLocalization? AppEventLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventScreenshotRelationships" /> class.
        /// </summary>
        /// <param name="appEventLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventScreenshotRelationships(
            global::AppStoreConnect.AppEventScreenshotRelationshipsAppEventLocalization? appEventLocalization)
        {
            this.AppEventLocalization = appEventLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventScreenshotRelationships" /> class.
        /// </summary>
        public AppEventScreenshotRelationships()
        {
        }

    }
}