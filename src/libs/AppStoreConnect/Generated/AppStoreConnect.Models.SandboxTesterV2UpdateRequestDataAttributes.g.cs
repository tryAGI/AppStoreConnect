
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxTesterV2UpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.TerritoryCodeJsonConverter))]
        public global::AppStoreConnect.TerritoryCode? Territory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruptPurchases")]
        public bool? InterruptPurchases { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionRenewalRate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRateJsonConverter))]
        public global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate? SubscriptionRenewalRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTesterV2UpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="territory"></param>
        /// <param name="interruptPurchases"></param>
        /// <param name="subscriptionRenewalRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxTesterV2UpdateRequestDataAttributes(
            global::AppStoreConnect.TerritoryCode? territory,
            bool? interruptPurchases,
            global::AppStoreConnect.SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate? subscriptionRenewalRate)
        {
            this.Territory = territory;
            this.InterruptPurchases = interruptPurchases;
            this.SubscriptionRenewalRate = subscriptionRenewalRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTesterV2UpdateRequestDataAttributes" /> class.
        /// </summary>
        public SandboxTesterV2UpdateRequestDataAttributes()
        {
        }

    }
}