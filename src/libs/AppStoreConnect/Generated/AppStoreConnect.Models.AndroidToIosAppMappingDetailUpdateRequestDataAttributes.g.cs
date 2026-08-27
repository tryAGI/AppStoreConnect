
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AndroidToIosAppMappingDetailUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packageName")]
        public string? PackageName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appSigningKeyPublicCertificateSha256Fingerprints")]
        public global::System.Collections.Generic.IList<string>? AppSigningKeyPublicCertificateSha256Fingerprints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidToIosAppMappingDetailUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="packageName"></param>
        /// <param name="appSigningKeyPublicCertificateSha256Fingerprints"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AndroidToIosAppMappingDetailUpdateRequestDataAttributes(
            string? packageName,
            global::System.Collections.Generic.IList<string>? appSigningKeyPublicCertificateSha256Fingerprints)
        {
            this.PackageName = packageName;
            this.AppSigningKeyPublicCertificateSha256Fingerprints = appSigningKeyPublicCertificateSha256Fingerprints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AndroidToIosAppMappingDetailUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AndroidToIosAppMappingDetailUpdateRequestDataAttributes()
        {
        }

    }
}