
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeCustomCodeUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCustomCodeUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeCustomCodeUpdateRequestDataAttributes(
            bool? active)
        {
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCustomCodeUpdateRequestDataAttributes" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeCustomCodeUpdateRequestDataAttributes()
        {
        }

    }
}