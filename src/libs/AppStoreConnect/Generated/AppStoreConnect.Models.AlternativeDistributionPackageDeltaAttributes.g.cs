
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlternativeDistributionPackageDeltaAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urlExpirationDate")]
        public global::System.DateTime? UrlExpirationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alternativeDistributionKeyBlob")]
        public string? AlternativeDistributionKeyBlob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileChecksum")]
        public string? FileChecksum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageDeltaAttributes" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="urlExpirationDate"></param>
        /// <param name="alternativeDistributionKeyBlob"></param>
        /// <param name="fileChecksum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionPackageDeltaAttributes(
            string? url,
            global::System.DateTime? urlExpirationDate,
            string? alternativeDistributionKeyBlob,
            string? fileChecksum)
        {
            this.Url = url;
            this.UrlExpirationDate = urlExpirationDate;
            this.AlternativeDistributionKeyBlob = alternativeDistributionKeyBlob;
            this.FileChecksum = fileChecksum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageDeltaAttributes" /> class.
        /// </summary>
        public AlternativeDistributionPackageDeltaAttributes()
        {
        }

    }
}