
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceTierEqualizationRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priceTierPricePoints")]
        public global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePoints? PriceTierPricePoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceTierEqualizationRelationships" /> class.
        /// </summary>
        /// <param name="priceTierPricePoints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceTierEqualizationRelationships(
            global::AppStoreConnect.SubscriptionPriceTierEqualizationRelationshipsPriceTierPricePoints? priceTierPricePoints)
        {
            this.PriceTierPricePoints = priceTierPricePoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceTierEqualizationRelationships" /> class.
        /// </summary>
        public SubscriptionPriceTierEqualizationRelationships()
        {
        }

    }
}