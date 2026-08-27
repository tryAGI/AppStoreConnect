
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionAvailabilityCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availableInNewTerritories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AvailableInNewTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAvailabilityCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="availableInNewTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionAvailabilityCreateRequestDataAttributes(
            bool availableInNewTerritories)
        {
            this.AvailableInNewTerritories = availableInNewTerritories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAvailabilityCreateRequestDataAttributes" /> class.
        /// </summary>
        public SubscriptionAvailabilityCreateRequestDataAttributes()
        {
        }

    }
}