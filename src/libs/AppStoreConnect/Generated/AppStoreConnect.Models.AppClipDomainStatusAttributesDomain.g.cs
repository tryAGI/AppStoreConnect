
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipDomainStatusAttributesDomain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isValid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedDate")]
        public global::System.DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipDomainStatusAttributesDomainErrorCodeJsonConverter))]
        public global::AppStoreConnect.AppClipDomainStatusAttributesDomainErrorCode? ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDomainStatusAttributesDomain" /> class.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="isValid"></param>
        /// <param name="lastUpdatedDate"></param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipDomainStatusAttributesDomain(
            string? domain,
            bool? isValid,
            global::System.DateTime? lastUpdatedDate,
            global::AppStoreConnect.AppClipDomainStatusAttributesDomainErrorCode? errorCode)
        {
            this.Domain = domain;
            this.IsValid = isValid;
            this.LastUpdatedDate = lastUpdatedDate;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDomainStatusAttributesDomain" /> class.
        /// </summary>
        public AppClipDomainStatusAttributesDomain()
        {
        }

    }
}