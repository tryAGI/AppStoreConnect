
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionUpdateRequestData Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="included"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionUpdateRequest(
            global::AppStoreConnect.SubscriptionUpdateRequestData data,
            global::System.Collections.Generic.IList<global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>>? included)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUpdateRequest" /> class.
        /// </summary>
        public SubscriptionUpdateRequest()
        {
        }

    }
}