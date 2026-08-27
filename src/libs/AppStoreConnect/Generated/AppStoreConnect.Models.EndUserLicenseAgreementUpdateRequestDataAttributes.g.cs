
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndUserLicenseAgreementUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agreementText")]
        public string? AgreementText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserLicenseAgreementUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="agreementText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUserLicenseAgreementUpdateRequestDataAttributes(
            string? agreementText)
        {
            this.AgreementText = agreementText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserLicenseAgreementUpdateRequestDataAttributes" /> class.
        /// </summary>
        public EndUserLicenseAgreementUpdateRequestDataAttributes()
        {
        }

    }
}