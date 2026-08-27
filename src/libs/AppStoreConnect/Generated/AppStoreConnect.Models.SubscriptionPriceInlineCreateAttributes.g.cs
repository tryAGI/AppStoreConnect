
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionPriceInlineCreateAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserveCurrentPrice")]
        public bool? PreserveCurrentPrice { get; set; }

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
        /// Initializes a new instance of the <see cref="SubscriptionPriceInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="preserveCurrentPrice"></param>
        /// <param name="planType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceInlineCreateAttributes(
            global::System.DateTime? startDate,
            bool? preserveCurrentPrice,
            global::AppStoreConnect.SubscriptionPlanType? planType)
        {
            this.StartDate = startDate;
            this.PreserveCurrentPrice = preserveCurrentPrice;
            this.PlanType = planType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceInlineCreateAttributes" /> class.
        /// </summary>
        public SubscriptionPriceInlineCreateAttributes()
        {
        }

    }
}