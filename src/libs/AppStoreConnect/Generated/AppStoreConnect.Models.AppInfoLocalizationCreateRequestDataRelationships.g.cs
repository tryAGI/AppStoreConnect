
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppInfoLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appInfo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppInfoLocalizationCreateRequestDataRelationshipsAppInfo AppInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppInfoLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.AppInfoLocalizationCreateRequestDataRelationshipsAppInfo appInfo)
        {
            this.AppInfo = appInfo ?? throw new global::System.ArgumentNullException(nameof(appInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppInfoLocalizationCreateRequestDataRelationships()
        {
        }

    }
}