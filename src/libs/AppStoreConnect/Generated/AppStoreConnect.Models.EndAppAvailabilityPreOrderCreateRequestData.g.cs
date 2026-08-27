
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndAppAvailabilityPreOrderCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.EndAppAvailabilityPreOrderCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndAppAvailabilityPreOrderCreateRequestData" /> class.
        /// </summary>
        /// <param name="relationships"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndAppAvailabilityPreOrderCreateRequestData(
            global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataRelationships relationships,
            global::AppStoreConnect.EndAppAvailabilityPreOrderCreateRequestDataType type)
        {
            this.Type = type;
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndAppAvailabilityPreOrderCreateRequestData" /> class.
        /// </summary>
        public EndAppAvailabilityPreOrderCreateRequestData()
        {
        }

    }
}