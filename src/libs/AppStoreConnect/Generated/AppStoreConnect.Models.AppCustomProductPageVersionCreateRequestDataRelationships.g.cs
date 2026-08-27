
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppCustomProductPageVersionCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPage AppCustomProductPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageLocalizations")]
        public global::AppStoreConnect.AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageLocalizations? AppCustomProductPageLocalizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPage"></param>
        /// <param name="appCustomProductPageLocalizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageVersionCreateRequestDataRelationships(
            global::AppStoreConnect.AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPage appCustomProductPage,
            global::AppStoreConnect.AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageLocalizations? appCustomProductPageLocalizations)
        {
            this.AppCustomProductPage = appCustomProductPage ?? throw new global::System.ArgumentNullException(nameof(appCustomProductPage));
            this.AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppCustomProductPageVersionCreateRequestDataRelationships()
        {
        }

    }
}