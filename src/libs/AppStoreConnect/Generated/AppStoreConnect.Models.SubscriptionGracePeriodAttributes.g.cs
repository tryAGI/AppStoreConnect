
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionGracePeriodAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("optIn")]
        public bool? OptIn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxOptIn")]
        public bool? SandboxOptIn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodDurationJsonConverter))]
        public global::AppStoreConnect.SubscriptionGracePeriodDuration? Duration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("renewalType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionGracePeriodAttributesRenewalTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType? RenewalType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGracePeriodAttributes" /> class.
        /// </summary>
        /// <param name="optIn"></param>
        /// <param name="sandboxOptIn"></param>
        /// <param name="duration"></param>
        /// <param name="renewalType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionGracePeriodAttributes(
            bool? optIn,
            bool? sandboxOptIn,
            global::AppStoreConnect.SubscriptionGracePeriodDuration? duration,
            global::AppStoreConnect.SubscriptionGracePeriodAttributesRenewalType? renewalType)
        {
            this.OptIn = optIn;
            this.SandboxOptIn = sandboxOptIn;
            this.Duration = duration;
            this.RenewalType = renewalType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGracePeriodAttributes" /> class.
        /// </summary>
        public SubscriptionGracePeriodAttributes()
        {
        }

    }
}