
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionOfferCodeCreateRequestDataAttributes
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
        public required global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionCustomerEligibility> CustomerEligibilities { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerEligibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferEligibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionOfferEligibility OfferEligibility { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionOfferDuration Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionOfferMode OfferMode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfPeriods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfPeriods { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenewEnabled")]
        public bool? AutoRenewEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetSubscriptionPlanType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPlanType? TargetSubscriptionPlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="customerEligibilities"></param>
        /// <param name="offerEligibility"></param>
        /// <param name="duration"></param>
        /// <param name="offerMode"></param>
        /// <param name="numberOfPeriods"></param>
        /// <param name="autoRenewEnabled"></param>
        /// <param name="targetSubscriptionPlanType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionOfferCodeCreateRequestDataAttributes(
            string name,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionCustomerEligibility> customerEligibilities,
            global::AppStoreConnect.SubscriptionOfferEligibility offerEligibility,
            global::AppStoreConnect.SubscriptionOfferDuration duration,
            global::AppStoreConnect.SubscriptionOfferMode offerMode,
            int numberOfPeriods,
            bool? autoRenewEnabled,
            global::AppStoreConnect.SubscriptionPlanType? targetSubscriptionPlanType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CustomerEligibilities = customerEligibilities ?? throw new global::System.ArgumentNullException(nameof(customerEligibilities));
            this.OfferEligibility = offerEligibility;
            this.Duration = duration;
            this.OfferMode = offerMode;
            this.NumberOfPeriods = numberOfPeriods;
            this.AutoRenewEnabled = autoRenewEnabled;
            this.TargetSubscriptionPlanType = targetSubscriptionPlanType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeCreateRequestDataAttributes" /> class.
        /// </summary>
        public SubscriptionOfferCodeCreateRequestDataAttributes()
        {
        }

    }
}