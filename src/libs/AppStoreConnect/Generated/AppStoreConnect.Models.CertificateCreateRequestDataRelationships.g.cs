
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificateCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merchantId")]
        public global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantId? MerchantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passTypeId")]
        public global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeId? PassTypeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="merchantId"></param>
        /// <param name="passTypeId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CertificateCreateRequestDataRelationships(
            global::AppStoreConnect.CertificateCreateRequestDataRelationshipsMerchantId? merchantId,
            global::AppStoreConnect.CertificateCreateRequestDataRelationshipsPassTypeId? passTypeId)
        {
            this.MerchantId = merchantId;
            this.PassTypeId = passTypeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateCreateRequestDataRelationships" /> class.
        /// </summary>
        public CertificateCreateRequestDataRelationships()
        {
        }

    }
}