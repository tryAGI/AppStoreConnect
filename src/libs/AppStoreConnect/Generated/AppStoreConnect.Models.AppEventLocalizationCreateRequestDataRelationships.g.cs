
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppEventLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appEvent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppEventLocalizationCreateRequestDataRelationshipsAppEvent AppEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appEvent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.AppEventLocalizationCreateRequestDataRelationshipsAppEvent appEvent)
        {
            this.AppEvent = appEvent ?? throw new global::System.ArgumentNullException(nameof(appEvent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppEventLocalizationCreateRequestDataRelationships()
        {
        }

    }
}