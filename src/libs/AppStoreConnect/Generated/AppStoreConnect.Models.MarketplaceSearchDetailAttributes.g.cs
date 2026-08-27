
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketplaceSearchDetailAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUrl")]
        public string? CatalogUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceSearchDetailAttributes" /> class.
        /// </summary>
        /// <param name="catalogUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarketplaceSearchDetailAttributes(
            string? catalogUrl)
        {
            this.CatalogUrl = catalogUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceSearchDetailAttributes" /> class.
        /// </summary>
        public MarketplaceSearchDetailAttributes()
        {
        }

    }
}