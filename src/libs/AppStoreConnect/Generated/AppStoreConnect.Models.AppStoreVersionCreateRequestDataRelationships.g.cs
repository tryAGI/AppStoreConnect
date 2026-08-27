
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreVersionLocalizations")]
        public global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizations? AppStoreVersionLocalizations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("build")]
        public global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuild? Build { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="appStoreVersionLocalizations"></param>
        /// <param name="build"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionCreateRequestDataRelationships(
            global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsApp app,
            global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsAppStoreVersionLocalizations? appStoreVersionLocalizations,
            global::AppStoreConnect.AppStoreVersionCreateRequestDataRelationshipsBuild? build)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.AppStoreVersionLocalizations = appStoreVersionLocalizations;
            this.Build = build;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppStoreVersionCreateRequestDataRelationships()
        {
        }

    }
}