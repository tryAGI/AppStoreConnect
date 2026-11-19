
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceChangePreviewCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proposedChanges")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceChangePreviewCreateRequestDataAttributesProposedChange>? ProposedChanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceChangePreviewCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="proposedChanges"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceChangePreviewCreateRequestDataAttributes(
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceChangePreviewCreateRequestDataAttributesProposedChange>? proposedChanges)
        {
            this.ProposedChanges = proposedChanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceChangePreviewCreateRequestDataAttributes" /> class.
        /// </summary>
        public SubscriptionPriceChangePreviewCreateRequestDataAttributes()
        {
        }

    }
}