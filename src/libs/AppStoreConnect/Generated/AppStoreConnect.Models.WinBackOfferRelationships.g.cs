
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WinBackOfferRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        public global::AppStoreConnect.WinBackOfferRelationshipsPrices? Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WinBackOfferRelationships" /> class.
        /// </summary>
        /// <param name="prices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WinBackOfferRelationships(
            global::AppStoreConnect.WinBackOfferRelationshipsPrices? prices)
        {
            this.Prices = prices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WinBackOfferRelationships" /> class.
        /// </summary>
        public WinBackOfferRelationships()
        {
        }

    }
}