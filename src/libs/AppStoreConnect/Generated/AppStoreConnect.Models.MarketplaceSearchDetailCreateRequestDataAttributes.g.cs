
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MarketplaceSearchDetailCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CatalogUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceSearchDetailCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="catalogUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarketplaceSearchDetailCreateRequestDataAttributes(
            string catalogUrl)
        {
            this.CatalogUrl = catalogUrl ?? throw new global::System.ArgumentNullException(nameof(catalogUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceSearchDetailCreateRequestDataAttributes" /> class.
        /// </summary>
        public MarketplaceSearchDetailCreateRequestDataAttributes()
        {
        }

    }
}