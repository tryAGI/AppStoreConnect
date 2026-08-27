
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPageVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersion appCustomProductPageVersion)
        {
            this.AppCustomProductPageVersion = appCustomProductPageVersion ?? throw new global::System.ArgumentNullException(nameof(appCustomProductPageVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppCustomProductPageLocalizationCreateRequestDataRelationships()
        {
        }

    }
}