
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCustomProductPageLocalizationInlineCreateRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageVersion")]
        public global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersion? AppCustomProductPageVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPageVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageLocalizationInlineCreateRelationships(
            global::AppStoreConnect.AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersion? appCustomProductPageVersion)
        {
            this.AppCustomProductPageVersion = appCustomProductPageVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationInlineCreateRelationships" /> class.
        /// </summary>
        public AppCustomProductPageLocalizationInlineCreateRelationships()
        {
        }

    }
}