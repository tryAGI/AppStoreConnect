
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndUserLicenseAgreementUpdateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territories")]
        public global::AppStoreConnect.EndUserLicenseAgreementUpdateRequestDataRelationshipsTerritories? Territories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserLicenseAgreementUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="territories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUserLicenseAgreementUpdateRequestDataRelationships(
            global::AppStoreConnect.EndUserLicenseAgreementUpdateRequestDataRelationshipsTerritories? territories)
        {
            this.Territories = territories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserLicenseAgreementUpdateRequestDataRelationships" /> class.
        /// </summary>
        public EndUserLicenseAgreementUpdateRequestDataRelationships()
        {
        }

    }
}