
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilities")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie>? CustomerEligibilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productionCodeCount")]
        public int? ProductionCodeCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxCodeCount")]
        public int? SandboxCodeCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="customerEligibilities"></param>
        /// <param name="productionCodeCount"></param>
        /// <param name="sandboxCodeCount"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeAttributes(
            string? name,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodeAttributesCustomerEligibilitie>? customerEligibilities,
            int? productionCodeCount,
            int? sandboxCodeCount,
            bool? active)
        {
            this.Name = name;
            this.CustomerEligibilities = customerEligibilities;
            this.ProductionCodeCount = productionCodeCount;
            this.SandboxCodeCount = sandboxCodeCount;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeAttributes" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeAttributes()
        {
        }

    }
}