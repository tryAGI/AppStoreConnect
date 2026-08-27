
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionIntroductoryOfferInlineCreateAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endDate")]
        public global::System.DateTime? EndDate { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("targetSubscriptionPlanType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPlanType? TargetSubscriptionPlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOfferInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="offerMode"></param>
        /// <param name="numberOfPeriods"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="targetSubscriptionPlanType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionIntroductoryOfferInlineCreateAttributes(
            global::AppStoreConnect.SubscriptionOfferDuration duration,
            global::AppStoreConnect.SubscriptionOfferMode offerMode,
            int numberOfPeriods,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::AppStoreConnect.SubscriptionPlanType? targetSubscriptionPlanType)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Duration = duration;
            this.OfferMode = offerMode;
            this.NumberOfPeriods = numberOfPeriods;
            this.TargetSubscriptionPlanType = targetSubscriptionPlanType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIntroductoryOfferInlineCreateAttributes" /> class.
        /// </summary>
        public SubscriptionIntroductoryOfferInlineCreateAttributes()
        {
        }

    }
}