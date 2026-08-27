
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseOfferCodeCustomCodeRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdByActor")]
        public global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActor? CreatedByActor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivatedByActor")]
        public global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActor? DeactivatedByActor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCustomCodeRelationships" /> class.
        /// </summary>
        /// <param name="createdByActor"></param>
        /// <param name="deactivatedByActor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseOfferCodeCustomCodeRelationships(
            global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsCreatedByActor? createdByActor,
            global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActor? deactivatedByActor)
        {
            this.CreatedByActor = createdByActor;
            this.DeactivatedByActor = deactivatedByActor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseOfferCodeCustomCodeRelationships" /> class.
        /// </summary>
        public InAppPurchaseOfferCodeCustomCodeRelationships()
        {
        }

    }
}