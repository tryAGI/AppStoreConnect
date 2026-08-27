
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppCustomProductPageVersionRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPage")]
        public global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPage? AppCustomProductPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageLocalizations")]
        public global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizations? AppCustomProductPageLocalizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPage"></param>
        /// <param name="appCustomProductPageLocalizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageVersionRelationships(
            global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPage? appCustomProductPage,
            global::AppStoreConnect.AppCustomProductPageVersionRelationshipsAppCustomProductPageLocalizations? appCustomProductPageLocalizations)
        {
            this.AppCustomProductPage = appCustomProductPage;
            this.AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionRelationships" /> class.
        /// </summary>
        public AppCustomProductPageVersionRelationships()
        {
        }

    }
}