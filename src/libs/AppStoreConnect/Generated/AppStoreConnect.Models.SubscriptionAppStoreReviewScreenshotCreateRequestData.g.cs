
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionAppStoreReviewScreenshotCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionAppStoreReviewScreenshotCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAppStoreReviewScreenshotCreateRequestData" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionAppStoreReviewScreenshotCreateRequestData(
            global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotCreateRequestDataAttributes attributes,
            global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotCreateRequestDataRelationships relationships,
            global::AppStoreConnect.SubscriptionAppStoreReviewScreenshotCreateRequestDataType type)
        {
            this.Type = type;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAppStoreReviewScreenshotCreateRequestData" /> class.
        /// </summary>
        public SubscriptionAppStoreReviewScreenshotCreateRequestData()
        {
        }

    }
}