
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCustomProductPageLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersion AppCustomProductPageVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placements")]
        public global::AppStoreConnect.AppCustomProductPageLocalizationCreateRequestDataRelationshipsPlacements? Placements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPageVersion"></param>
        /// <param name="placements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersion appCustomProductPageVersion,
            global::AppStoreConnect.AppCustomProductPageLocalizationCreateRequestDataRelationshipsPlacements? placements)
        {
            this.AppCustomProductPageVersion = appCustomProductPageVersion ?? throw new global::System.ArgumentNullException(nameof(appCustomProductPageVersion));
            this.Placements = placements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppCustomProductPageLocalizationCreateRequestDataRelationships()
        {
        }

    }
}