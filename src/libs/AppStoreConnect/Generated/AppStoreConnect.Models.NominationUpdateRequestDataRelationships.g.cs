
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NominationUpdateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relatedApps")]
        public global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedApps? RelatedApps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppEvents")]
        public global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEvents? InAppEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedTerritories")]
        public global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritories? SupportedTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationUpdateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="relatedApps"></param>
        /// <param name="inAppEvents"></param>
        /// <param name="supportedTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NominationUpdateRequestDataRelationships(
            global::AppStoreConnect.NominationUpdateRequestDataRelationshipsRelatedApps? relatedApps,
            global::AppStoreConnect.NominationUpdateRequestDataRelationshipsInAppEvents? inAppEvents,
            global::AppStoreConnect.NominationUpdateRequestDataRelationshipsSupportedTerritories? supportedTerritories)
        {
            this.RelatedApps = relatedApps;
            this.InAppEvents = inAppEvents;
            this.SupportedTerritories = supportedTerritories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationUpdateRequestDataRelationships" /> class.
        /// </summary>
        public NominationUpdateRequestDataRelationships()
        {
        }

    }
}