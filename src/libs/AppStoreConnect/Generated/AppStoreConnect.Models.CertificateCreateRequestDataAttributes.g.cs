
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificateCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("csrContent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CsrContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certificateType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.CertificateType2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.CertificateType2 CertificateType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="csrContent"></param>
        /// <param name="certificateType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CertificateCreateRequestDataAttributes(
            string csrContent,
            global::AppStoreConnect.CertificateType2 certificateType)
        {
            this.CsrContent = csrContent ?? throw new global::System.ArgumentNullException(nameof(csrContent));
            this.CertificateType = certificateType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCreateRequestDataAttributes" /> class.
        /// </summary>
        public CertificateCreateRequestDataAttributes()
        {
        }

    }
}