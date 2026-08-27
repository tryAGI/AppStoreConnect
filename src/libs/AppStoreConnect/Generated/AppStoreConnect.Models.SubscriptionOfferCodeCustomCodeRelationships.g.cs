
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionOfferCodeCustomCodeRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerCode")]
        public global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCode? OfferCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeCustomCodeRelationships" /> class.
        /// </summary>
        /// <param name="offerCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionOfferCodeCustomCodeRelationships(
            global::AppStoreConnect.SubscriptionOfferCodeCustomCodeRelationshipsOfferCode? offerCode)
        {
            this.OfferCode = offerCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeCustomCodeRelationships" /> class.
        /// </summary>
        public SubscriptionOfferCodeCustomCodeRelationships()
        {
        }

    }
}