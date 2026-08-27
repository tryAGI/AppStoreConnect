
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NominationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relatedApps")]
        public global::AppStoreConnect.NominationRelationshipsRelatedApps? RelatedApps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdByActor")]
        public global::AppStoreConnect.NominationRelationshipsCreatedByActor? CreatedByActor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastModifiedByActor")]
        public global::AppStoreConnect.NominationRelationshipsLastModifiedByActor? LastModifiedByActor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedByActor")]
        public global::AppStoreConnect.NominationRelationshipsSubmittedByActor? SubmittedByActor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppEvents")]
        public global::AppStoreConnect.NominationRelationshipsInAppEvents? InAppEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportedTerritories")]
        public global::AppStoreConnect.NominationRelationshipsSupportedTerritories? SupportedTerritories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationRelationships" /> class.
        /// </summary>
        /// <param name="relatedApps"></param>
        /// <param name="createdByActor"></param>
        /// <param name="lastModifiedByActor"></param>
        /// <param name="submittedByActor"></param>
        /// <param name="inAppEvents"></param>
        /// <param name="supportedTerritories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NominationRelationships(
            global::AppStoreConnect.NominationRelationshipsRelatedApps? relatedApps,
            global::AppStoreConnect.NominationRelationshipsCreatedByActor? createdByActor,
            global::AppStoreConnect.NominationRelationshipsLastModifiedByActor? lastModifiedByActor,
            global::AppStoreConnect.NominationRelationshipsSubmittedByActor? submittedByActor,
            global::AppStoreConnect.NominationRelationshipsInAppEvents? inAppEvents,
            global::AppStoreConnect.NominationRelationshipsSupportedTerritories? supportedTerritories)
        {
            this.RelatedApps = relatedApps;
            this.CreatedByActor = createdByActor;
            this.LastModifiedByActor = lastModifiedByActor;
            this.SubmittedByActor = submittedByActor;
            this.InAppEvents = inAppEvents;
            this.SupportedTerritories = supportedTerritories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NominationRelationships" /> class.
        /// </summary>
        public NominationRelationships()
        {
        }

    }
}