
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionPricePointRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territory")]
        public global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritory? Territory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("equalizations")]
        public global::AppStoreConnect.SubscriptionPricePointRelationshipsEqualizations? Equalizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adjustedEqualizations")]
        public global::AppStoreConnect.SubscriptionPricePointRelationshipsAdjustedEqualizations? AdjustedEqualizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPricePointRelationships" /> class.
        /// </summary>
        /// <param name="territory"></param>
        /// <param name="equalizations"></param>
        /// <param name="adjustedEqualizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPricePointRelationships(
            global::AppStoreConnect.SubscriptionPricePointRelationshipsTerritory? territory,
            global::AppStoreConnect.SubscriptionPricePointRelationshipsEqualizations? equalizations,
            global::AppStoreConnect.SubscriptionPricePointRelationshipsAdjustedEqualizations? adjustedEqualizations)
        {
            this.Territory = territory;
            this.Equalizations = equalizations;
            this.AdjustedEqualizations = adjustedEqualizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPricePointRelationships" /> class.
        /// </summary>
        public SubscriptionPricePointRelationships()
        {
        }

    }
}