
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlternativeDistributionPackageVersionAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileChecksum")]
        public string? FileChecksum { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AlternativeDistributionPackageVersionAttributesStateJsonConverter))]
        public global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageVersionAttributes" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="urlExpirationDate"></param>
        /// <param name="version"></param>
        /// <param name="fileChecksum"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionPackageVersionAttributes(
            string? url,
            global::System.DateTime? urlExpirationDate,
            string? version,
            string? fileChecksum,
            global::AppStoreConnect.AlternativeDistributionPackageVersionAttributesState? state)
        {
            this.Url = url;
            this.UrlExpirationDate = urlExpirationDate;
            this.Version = version;
            this.FileChecksum = fileChecksum;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionPackageVersionAttributes" /> class.
        /// </summary>
        public AlternativeDistributionPackageVersionAttributes()
        {
        }

    }
}