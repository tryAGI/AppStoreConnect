
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppCustomProductPageCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageVersions")]
        public global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersions? AppCustomProductPageVersions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionTemplate")]
        public global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplate? AppStoreVersionTemplate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customProductPageTemplate")]
        public global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplate? CustomProductPageTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="appCustomProductPageVersions"></param>
        /// <param name="appStoreVersionTemplate"></param>
        /// <param name="customProductPageTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageCreateRequestDataRelationships(
            global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsApp app,
            global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppCustomProductPageVersions? appCustomProductPageVersions,
            global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsAppStoreVersionTemplate? appStoreVersionTemplate,
            global::AppStoreConnect.AppCustomProductPageCreateRequestDataRelationshipsCustomProductPageTemplate? customProductPageTemplate)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.AppCustomProductPageVersions = appCustomProductPageVersions;
            this.AppStoreVersionTemplate = appStoreVersionTemplate;
            this.CustomProductPageTemplate = customProductPageTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppCustomProductPageCreateRequestDataRelationships()
        {
        }

    }
}