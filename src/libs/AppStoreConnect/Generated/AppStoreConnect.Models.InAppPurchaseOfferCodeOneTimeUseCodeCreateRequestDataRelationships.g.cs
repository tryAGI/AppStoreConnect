
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCode OfferCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="offerCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationships(
            global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationshipsOfferCode offerCode)
        {
            this.OfferCode = offerCode ?? throw new global::System.ArgumentNullException(nameof(offerCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationships" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeOneTimeUseCodeCreateRequestDataRelationships()
        {
        }

    }
}