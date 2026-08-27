
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventVideoClipRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEventLocalization")]
        public global::AppStoreConnect.AppEventVideoClipRelationshipsAppEventLocalization? AppEventLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventVideoClipRelationships" /> class.
        /// </summary>
        /// <param name="appEventLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventVideoClipRelationships(
            global::AppStoreConnect.AppEventVideoClipRelationshipsAppEventLocalization? appEventLocalization)
        {
            this.AppEventLocalization = appEventLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventVideoClipRelationships" /> class.
        /// </summary>
        public AppEventVideoClipRelationships()
        {
        }

    }
}