
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlternativeDistributionDomainCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionDomainCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="referenceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionDomainCreateRequestDataAttributes(
            string domain,
            string referenceName)
        {
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionDomainCreateRequestDataAttributes" /> class.
        /// </summary>
        public AlternativeDistributionDomainCreateRequestDataAttributes()
        {
        }

    }
}