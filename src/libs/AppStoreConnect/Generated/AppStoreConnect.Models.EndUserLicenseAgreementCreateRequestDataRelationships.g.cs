
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EndUserLicenseAgreementCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.EndUserLicenseAgreementCreateRequestDataRelationshipsApp App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.EndUserLicenseAgreementCreateRequestDataRelationshipsTerritories Territories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserLicenseAgreementCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="territories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndUserLicenseAgreementCreateRequestDataRelationships(
            global::AppStoreConnect.EndUserLicenseAgreementCreateRequestDataRelationshipsApp app,
            global::AppStoreConnect.EndUserLicenseAgreementCreateRequestDataRelationshipsTerritories territories)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Territories = territories ?? throw new global::System.ArgumentNullException(nameof(territories));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndUserLicenseAgreementCreateRequestDataRelationships" /> class.
        /// </summary>
        public EndUserLicenseAgreementCreateRequestDataRelationships()
        {
        }

    }
}