
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppEventVideoClipCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEventLocalization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalization AppEventLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventVideoClipCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appEventLocalization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventVideoClipCreateRequestDataRelationships(
            global::AppStoreConnect.AppEventVideoClipCreateRequestDataRelationshipsAppEventLocalization appEventLocalization)
        {
            this.AppEventLocalization = appEventLocalization ?? throw new global::System.ArgumentNullException(nameof(appEventLocalization));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventVideoClipCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppEventVideoClipCreateRequestDataRelationships()
        {
        }

    }
}