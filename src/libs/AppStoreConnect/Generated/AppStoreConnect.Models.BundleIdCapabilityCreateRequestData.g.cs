
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BundleIdCapabilityCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.BundleIdCapabilityCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.BundleIdCapabilityCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BundleIdCapabilityCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationships Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCapabilityCreateRequestData" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="relationships"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BundleIdCapabilityCreateRequestData(
            global::AppStoreConnect.BundleIdCapabilityCreateRequestDataAttributes attributes,
            global::AppStoreConnect.BundleIdCapabilityCreateRequestDataRelationships relationships,
            global::AppStoreConnect.BundleIdCapabilityCreateRequestDataType type)
        {
            this.Type = type;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Relationships = relationships ?? throw new global::System.ArgumentNullException(nameof(relationships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BundleIdCapabilityCreateRequestData" /> class.
        /// </summary>
        public BundleIdCapabilityCreateRequestData()
        {
        }

    }
}