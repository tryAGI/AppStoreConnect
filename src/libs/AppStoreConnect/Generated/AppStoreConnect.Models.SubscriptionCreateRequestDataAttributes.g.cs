
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProductId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("familySharable")]
        public bool? FamilySharable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionPeriod")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionCreateRequestDataAttributesSubscriptionPeriodJsonConverter))]
        public global::AppStoreConnect.SubscriptionCreateRequestDataAttributesSubscriptionPeriod? SubscriptionPeriod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewNote")]
        public string? ReviewNote { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupLevel")]
        public int? GroupLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="productId"></param>
        /// <param name="familySharable"></param>
        /// <param name="subscriptionPeriod"></param>
        /// <param name="reviewNote"></param>
        /// <param name="groupLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionCreateRequestDataAttributes(
            string name,
            string productId,
            bool? familySharable,
            global::AppStoreConnect.SubscriptionCreateRequestDataAttributesSubscriptionPeriod? subscriptionPeriod,
            string? reviewNote,
            int? groupLevel)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProductId = productId ?? throw new global::System.ArgumentNullException(nameof(productId));
            this.FamilySharable = familySharable;
            this.SubscriptionPeriod = subscriptionPeriod;
            this.ReviewNote = reviewNote;
            this.GroupLevel = groupLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCreateRequestDataAttributes" /> class.
        /// </summary>
        public SubscriptionCreateRequestDataAttributes()
        {
        }

    }
}