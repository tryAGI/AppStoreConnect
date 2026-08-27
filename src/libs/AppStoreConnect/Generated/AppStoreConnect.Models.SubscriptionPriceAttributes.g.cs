
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserved")]
        public bool? Preserved { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPlanTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPlanType? PlanType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceAttributes" /> class.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="preserved"></param>
        /// <param name="planType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceAttributes(
            global::System.DateTime? startDate,
            bool? preserved,
            global::AppStoreConnect.SubscriptionPlanType? planType)
        {
            this.StartDate = startDate;
            this.Preserved = preserved;
            this.PlanType = planType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceAttributes" /> class.
        /// </summary>
        public SubscriptionPriceAttributes()
        {
        }

    }
}