
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie> CustomerEligibilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="customerEligibilities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeCreateRequestDataAttributes(
            string name,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeCreateRequestDataAttributesCustomerEligibilitie> customerEligibilities)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CustomerEligibilities = customerEligibilities ?? throw new global::System.ArgumentNullException(nameof(customerEligibilities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeCreateRequestDataAttributes()
        {
        }

    }
}