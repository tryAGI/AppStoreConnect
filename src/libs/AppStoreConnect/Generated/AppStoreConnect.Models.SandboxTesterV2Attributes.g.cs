
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxTesterV2Attributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acAccountName")]
        public string? AcAccountName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.TerritoryCodeJsonConverter))]
        public global::AppStoreConnect.TerritoryCode? Territory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applePayCompatible")]
        public bool? ApplePayCompatible { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruptPurchases")]
        public bool? InterruptPurchases { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionRenewalRate")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SandboxTesterV2AttributesSubscriptionRenewalRateJsonConverter))]
        public global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate? SubscriptionRenewalRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTesterV2Attributes" /> class.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="acAccountName"></param>
        /// <param name="territory"></param>
        /// <param name="applePayCompatible"></param>
        /// <param name="interruptPurchases"></param>
        /// <param name="subscriptionRenewalRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxTesterV2Attributes(
            string? firstName,
            string? lastName,
            string? acAccountName,
            global::AppStoreConnect.TerritoryCode? territory,
            bool? applePayCompatible,
            bool? interruptPurchases,
            global::AppStoreConnect.SandboxTesterV2AttributesSubscriptionRenewalRate? subscriptionRenewalRate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AcAccountName = acAccountName;
            this.Territory = territory;
            this.ApplePayCompatible = applePayCompatible;
            this.InterruptPurchases = interruptPurchases;
            this.SubscriptionRenewalRate = subscriptionRenewalRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxTesterV2Attributes" /> class.
        /// </summary>
        public SandboxTesterV2Attributes()
        {
        }

    }
}