
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipDomainStatusAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domains")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDomainStatusAttributesDomain>? Domains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdatedDate")]
        public global::System.DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDomainStatusAttributes" /> class.
        /// </summary>
        /// <param name="domains"></param>
        /// <param name="lastUpdatedDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipDomainStatusAttributes(
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDomainStatusAttributesDomain>? domains,
            global::System.DateTime? lastUpdatedDate)
        {
            this.Domains = domains;
            this.LastUpdatedDate = lastUpdatedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDomainStatusAttributes" /> class.
        /// </summary>
        public AppClipDomainStatusAttributes()
        {
        }

    }
}