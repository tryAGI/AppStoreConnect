
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionOfferUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilityPaidSubscriptionDurationInMonths")]
        public int? CustomerEligibilityPaidSubscriptionDurationInMonths { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerEligibilityWaitBetweenOffersInMonths")]
        public int? CustomerEligibilityWaitBetweenOffersInMonths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="customerEligibilityPaidSubscriptionDurationInMonths"></param>
        /// <param name="customerEligibilityWaitBetweenOffersInMonths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionOfferUpdateRequestDataAttributes(
            int? customerEligibilityPaidSubscriptionDurationInMonths,
            int? customerEligibilityWaitBetweenOffersInMonths)
        {
            this.CustomerEligibilityPaidSubscriptionDurationInMonths = customerEligibilityPaidSubscriptionDurationInMonths;
            this.CustomerEligibilityWaitBetweenOffersInMonths = customerEligibilityWaitBetweenOffersInMonths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionOfferUpdateRequestDataAttributes" /> class.
        /// </summary>
        public RetentionOfferUpdateRequestDataAttributes()
        {
        }

    }
}