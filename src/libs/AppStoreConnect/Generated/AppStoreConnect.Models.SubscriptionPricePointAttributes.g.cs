
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPricePointAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerPrice")]
        public string? CustomerPrice { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proceeds")]
        public string? Proceeds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proceedsYear2")]
        public string? ProceedsYear2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPricePointAttributes" /> class.
        /// </summary>
        /// <param name="customerPrice"></param>
        /// <param name="proceeds"></param>
        /// <param name="proceedsYear2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPricePointAttributes(
            string? customerPrice,
            string? proceeds,
            string? proceedsYear2)
        {
            this.CustomerPrice = customerPrice;
            this.Proceeds = proceeds;
            this.ProceedsYear2 = proceedsYear2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPricePointAttributes" /> class.
        /// </summary>
        public SubscriptionPricePointAttributes()
        {
        }

    }
}