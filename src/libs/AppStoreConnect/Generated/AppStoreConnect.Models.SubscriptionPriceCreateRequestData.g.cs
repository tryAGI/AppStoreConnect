
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionPriceCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionPriceCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.SubscriptionPriceCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.SubscriptionPriceCreateRequestDataAttributes? Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.SubscriptionPriceCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceCreateRequestData" /> class.
        /// </summary>
        /// <param name="relationships"></param>
        /// <param name="type"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPriceCreateRequestData(
            global::AppStoreConnect.SubscriptionPriceCreateRequestDataRelationships relationships,
            global::AppStoreConnect.SubscriptionPriceCreateRequestDataType type,
            global::AppStoreConnect.SubscriptionPriceCreateRequestDataAttributes? attributes)
        {
            this.Type = type;
            this.Attributes = attributes;
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPriceCreateRequestData" /> class.
        /// </summary>
        public SubscriptionPriceCreateRequestData()
        {
        }

    }
}