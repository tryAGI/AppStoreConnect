
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlternativeDistributionDomainAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        public string? ReferenceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionDomainAttributes" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="referenceName"></param>
        /// <param name="createdDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionDomainAttributes(
            string? domain,
            string? referenceName,
            global::System.DateTime? createdDate)
        {
            this.Domain = domain;
            this.ReferenceName = referenceName;
            this.CreatedDate = createdDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionDomainAttributes" /> class.
        /// </summary>
        public AlternativeDistributionDomainAttributes()
        {
        }

    }
}