
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AndroidToIosAppMappingDetailCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appSigningKeyPublicCertificateSha256Fingerprints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AppSigningKeyPublicCertificateSha256Fingerprints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidToIosAppMappingDetailCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="packageName"></param>
        /// <param name="appSigningKeyPublicCertificateSha256Fingerprints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AndroidToIosAppMappingDetailCreateRequestDataAttributes(
            string packageName,
            global::System.Collections.Generic.IList<string> appSigningKeyPublicCertificateSha256Fingerprints)
        {
            this.PackageName = packageName ?? throw new global::System.ArgumentNullException(nameof(packageName));
            this.AppSigningKeyPublicCertificateSha256Fingerprints = appSigningKeyPublicCertificateSha256Fingerprints ?? throw new global::System.ArgumentNullException(nameof(appSigningKeyPublicCertificateSha256Fingerprints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidToIosAppMappingDetailCreateRequestDataAttributes" /> class.
        /// </summary>
        public AndroidToIosAppMappingDetailCreateRequestDataAttributes()
        {
        }

    }
}