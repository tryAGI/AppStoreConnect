
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionAppStoreReviewScreenshotUpdateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionAppStoreReviewScreenshotUpdateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotUpdateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotUpdateRequestDataAttributes? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAppStoreReviewScreenshotUpdateRequestData" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionAppStoreReviewScreenshotUpdateRequestData(
            string id,
            global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotUpdateRequestDataType type,
            global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotUpdateRequestDataAttributes? attributes)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAppStoreReviewScreenshotUpdateRequestData" /> class.
        /// </summary>
        public SubscriptionAppStoreReviewScreenshotUpdateRequestData()
        {
        }

    }
}