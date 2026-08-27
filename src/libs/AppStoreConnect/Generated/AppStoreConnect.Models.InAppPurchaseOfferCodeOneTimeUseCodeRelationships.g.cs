
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeOneTimeUseCodeRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsValues? Values { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdByActor")]
        public global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsCreatedByActor? CreatedByActor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivatedByActor")]
        public global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsDeactivatedByActor? DeactivatedByActor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeOneTimeUseCodeRelationships" /> class.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="createdByActor"></param>
        /// <param name="deactivatedByActor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeOneTimeUseCodeRelationships(
            global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsValues? values,
            global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsCreatedByActor? createdByActor,
            global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsDeactivatedByActor? deactivatedByActor)
        {
            this.Values = values;
            this.CreatedByActor = createdByActor;
            this.DeactivatedByActor = deactivatedByActor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeOneTimeUseCodeRelationships" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeOneTimeUseCodeRelationships()
        {
        }

    }
}