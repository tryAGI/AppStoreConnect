
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCustomProductPageRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        public global::AppStoreConnect.AppCustomProductPageRelationshipsApp? App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageVersions")]
        public global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersions? AppCustomProductPageVersions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="appCustomProductPageVersions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageRelationships(
            global::AppStoreConnect.AppCustomProductPageRelationshipsApp? app,
            global::AppStoreConnect.AppCustomProductPageRelationshipsAppCustomProductPageVersions? appCustomProductPageVersions)
        {
            this.App = app;
            this.AppCustomProductPageVersions = appCustomProductPageVersions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageRelationships" /> class.
        /// </summary>
        public AppCustomProductPageRelationships()
        {
        }

    }
}