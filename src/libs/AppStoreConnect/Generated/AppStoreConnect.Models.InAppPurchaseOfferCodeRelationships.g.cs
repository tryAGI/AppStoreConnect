
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneTimeUseCodes")]
        public global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodes? OneTimeUseCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customCodes")]
        public global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodes? CustomCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        public global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPrices? Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeRelationships" /> class.
        /// </summary>
        /// <param name="oneTimeUseCodes"></param>
        /// <param name="customCodes"></param>
        /// <param name="prices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeRelationships(
            global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsOneTimeUseCodes? oneTimeUseCodes,
            global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsCustomCodes? customCodes,
            global::AppStoreConnect.InAppPurchaseOfferCodeRelationshipsPrices? prices)
        {
            this.OneTimeUseCodes = oneTimeUseCodes;
            this.CustomCodes = customCodes;
            this.Prices = prices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeRelationships" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeRelationships()
        {
        }

    }
}