
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionOfferCodeOneTimeUseCodeRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerCode")]
        public global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCode? OfferCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsValues? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeOneTimeUseCodeRelationships" /> class.
        /// </summary>
        /// <param name="offerCode"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionOfferCodeOneTimeUseCodeRelationships(
            global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsOfferCode? offerCode,
            global::AppStoreConnect.SubscriptionOfferCodeOneTimeUseCodeRelationshipsValues? values)
        {
            this.OfferCode = offerCode;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeOneTimeUseCodeRelationships" /> class.
        /// </summary>
        public SubscriptionOfferCodeOneTimeUseCodeRelationships()
        {
        }

    }
}