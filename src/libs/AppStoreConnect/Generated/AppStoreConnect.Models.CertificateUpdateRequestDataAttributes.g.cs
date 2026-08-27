
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CertificateUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activated")]
        public bool? Activated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="activated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CertificateUpdateRequestDataAttributes(
            bool? activated)
        {
            this.Activated = activated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateUpdateRequestDataAttributes" /> class.
        /// </summary>
        public CertificateUpdateRequestDataAttributes()
        {
        }

    }
}