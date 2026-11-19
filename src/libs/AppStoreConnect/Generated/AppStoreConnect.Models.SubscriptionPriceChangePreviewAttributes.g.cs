
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceChangePreviewAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changeResults")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceChangePreviewAttributesChangeResult>? ChangeResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceChangePreviewAttributes" /> class.
        /// </summary>
        /// <param name="changeResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceChangePreviewAttributes(
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceChangePreviewAttributesChangeResult>? changeResults)
        {
            this.ChangeResults = changeResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceChangePreviewAttributes" /> class.
        /// </summary>
        public SubscriptionPriceChangePreviewAttributes()
        {
        }

    }
}