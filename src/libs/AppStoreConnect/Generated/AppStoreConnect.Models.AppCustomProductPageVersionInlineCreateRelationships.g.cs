
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppCustomProductPageVersionInlineCreateRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPage")]
        public global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage? AppCustomProductPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appCustomProductPageLocalizations")]
        public global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizations? AppCustomProductPageLocalizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionInlineCreateRelationships" /> class.
        /// </summary>
        /// <param name="appCustomProductPage"></param>
        /// <param name="appCustomProductPageLocalizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageVersionInlineCreateRelationships(
            global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPage? appCustomProductPage,
            global::AppStoreConnect.AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageLocalizations? appCustomProductPageLocalizations)
        {
            this.AppCustomProductPage = appCustomProductPage;
            this.AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageVersionInlineCreateRelationships" /> class.
        /// </summary>
        public AppCustomProductPageVersionInlineCreateRelationships()
        {
        }

    }
}