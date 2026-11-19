
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceChangePreviewCreateRequestDataAttributesProposedChange
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territoryId")]
        public string? TerritoryId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basePricePointId")]
        public string? BasePricePointId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalPriceTiers")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.ProposedSubscriptionPriceTier>? AdditionalPriceTiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceChangePreviewCreateRequestDataAttributesProposedChange" /> class.
        /// </summary>
        /// <param name="territoryId"></param>
        /// <param name="startDate"></param>
        /// <param name="basePricePointId"></param>
        /// <param name="additionalPriceTiers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceChangePreviewCreateRequestDataAttributesProposedChange(
            string? territoryId,
            global::System.DateTime? startDate,
            string? basePricePointId,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ProposedSubscriptionPriceTier>? additionalPriceTiers)
        {
            this.TerritoryId = territoryId;
            this.StartDate = startDate;
            this.BasePricePointId = basePricePointId;
            this.AdditionalPriceTiers = additionalPriceTiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceChangePreviewCreateRequestDataAttributesProposedChange" /> class.
        /// </summary>
        public SubscriptionPriceChangePreviewCreateRequestDataAttributesProposedChange()
        {
        }

    }
}