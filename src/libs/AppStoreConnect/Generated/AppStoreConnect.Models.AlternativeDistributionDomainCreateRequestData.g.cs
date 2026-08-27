
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlternativeDistributionDomainCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AlternativeDistributionDomainCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.AlternativeDistributionDomainCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AlternativeDistributionDomainCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionDomainCreateRequestData" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionDomainCreateRequestData(
            global::AppStoreConnect.AlternativeDistributionDomainCreateRequestDataAttributes attributes,
            global::AppStoreConnect.AlternativeDistributionDomainCreateRequestDataType type)
        {
            this.Type = type;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionDomainCreateRequestData" /> class.
        /// </summary>
        public AlternativeDistributionDomainCreateRequestData()
        {
        }

    }
}