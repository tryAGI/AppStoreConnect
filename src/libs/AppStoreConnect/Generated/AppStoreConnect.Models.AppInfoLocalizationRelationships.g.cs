
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppInfoLocalizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appInfo")]
        public global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfo? AppInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoLocalizationRelationships" /> class.
        /// </summary>
        /// <param name="appInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppInfoLocalizationRelationships(
            global::AppStoreConnect.AppInfoLocalizationRelationshipsAppInfo? appInfo)
        {
            this.AppInfo = appInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoLocalizationRelationships" /> class.
        /// </summary>
        public AppInfoLocalizationRelationships()
        {
        }

    }
}