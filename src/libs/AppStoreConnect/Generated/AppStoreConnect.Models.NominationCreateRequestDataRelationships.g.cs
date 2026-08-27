
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NominationCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relatedApps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedApps RelatedApps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppEvents")]
        public global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEvents? InAppEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedTerritories")]
        public global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritories? SupportedTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="relatedApps"></param>
        /// <param name="inAppEvents"></param>
        /// <param name="supportedTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NominationCreateRequestDataRelationships(
            global::AppStoreConnect.NominationCreateRequestDataRelationshipsRelatedApps relatedApps,
            global::AppStoreConnect.NominationCreateRequestDataRelationshipsInAppEvents? inAppEvents,
            global::AppStoreConnect.NominationCreateRequestDataRelationshipsSupportedTerritories? supportedTerritories)
        {
            this.RelatedApps = relatedApps ?? throw new global::System.ArgumentNullException(nameof(relatedApps));
            this.InAppEvents = inAppEvents;
            this.SupportedTerritories = supportedTerritories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationCreateRequestDataRelationships" /> class.
        /// </summary>
        public NominationCreateRequestDataRelationships()
        {
        }

    }
}