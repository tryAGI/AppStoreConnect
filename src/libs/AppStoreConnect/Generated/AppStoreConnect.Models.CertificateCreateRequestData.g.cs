
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificateCreateRequestData
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CertificateCreateRequestDataTypeJsonConverter))]
        public global::AppStoreConnect.CertificateCreateRequestDataType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.CertificateCreateRequestDataAttributes Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationships")]
        public global::AppStoreConnect.CertificateCreateRequestDataRelationships? Relationships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCreateRequestData" /> class.
        /// </summary>
        /// <param name="attributes"></param>
        /// <param name="type"></param>
        /// <param name="relationships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CertificateCreateRequestData(
            global::AppStoreConnect.CertificateCreateRequestDataAttributes attributes,
            global::AppStoreConnect.CertificateCreateRequestDataType type,
            global::AppStoreConnect.CertificateCreateRequestDataRelationships? relationships)
        {
            this.Type = type;
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Relationships = relationships;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCreateRequestData" /> class.
        /// </summary>
        public CertificateCreateRequestData()
        {
        }

    }
}