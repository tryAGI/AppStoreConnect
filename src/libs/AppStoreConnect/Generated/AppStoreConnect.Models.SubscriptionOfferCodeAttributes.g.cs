
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionOfferCodeAttributes
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
        public global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionCustomerEligibility>? CustomerEligibilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerEligibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferEligibilityJsonConverter))]
        public global::AppStoreConnect.SubscriptionOfferEligibility? OfferEligibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferDurationJsonConverter))]
        public global::AppStoreConnect.SubscriptionOfferDuration? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionOfferModeJsonConverter))]
        public global::AppStoreConnect.SubscriptionOfferMode? OfferMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfPeriods")]
        public int? NumberOfPeriods { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalNumberOfCodes")]
        public int? TotalNumberOfCodes { get; set; }

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
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="customerEligibilities"></param>
        /// <param name="offerEligibility"></param>
        /// <param name="duration"></param>
        /// <param name="offerMode"></param>
        /// <param name="numberOfPeriods"></param>
        /// <param name="totalNumberOfCodes"></param>
        /// <param name="productionCodeCount"></param>
        /// <param name="sandboxCodeCount"></param>
        /// <param name="active"></param>
        /// <param name="autoRenewEnabled"></param>
        /// <param name="targetSubscriptionPlanType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionOfferCodeAttributes(
            string? name,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionCustomerEligibility>? customerEligibilities,
            global::AppStoreConnect.SubscriptionOfferEligibility? offerEligibility,
            global::AppStoreConnect.SubscriptionOfferDuration? duration,
            global::AppStoreConnect.SubscriptionOfferMode? offerMode,
            int? numberOfPeriods,
            int? totalNumberOfCodes,
            int? productionCodeCount,
            int? sandboxCodeCount,
            bool? active,
            bool? autoRenewEnabled,
            global::AppStoreConnect.SubscriptionPlanType? targetSubscriptionPlanType)
        {
            this.Name = name;
            this.CustomerEligibilities = customerEligibilities;
            this.OfferEligibility = offerEligibility;
            this.Duration = duration;
            this.OfferMode = offerMode;
            this.NumberOfPeriods = numberOfPeriods;
            this.TotalNumberOfCodes = totalNumberOfCodes;
            this.ProductionCodeCount = productionCodeCount;
            this.SandboxCodeCount = sandboxCodeCount;
            this.Active = active;
            this.AutoRenewEnabled = autoRenewEnabled;
            this.TargetSubscriptionPlanType = targetSubscriptionPlanType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionOfferCodeAttributes" /> class.
        /// </summary>
        public SubscriptionOfferCodeAttributes()
        {
        }

    }
}