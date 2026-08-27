
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseContentRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseV2")]
        public global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2? InAppPurchaseV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseContentRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchaseV2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseContentRelationships(
            global::AppStoreConnect.InAppPurchaseContentRelationshipsInAppPurchaseV2? inAppPurchaseV2)
        {
            this.InAppPurchaseV2 = inAppPurchaseV2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseContentRelationships" /> class.
        /// </summary>
        public InAppPurchaseContentRelationships()
        {
        }

    }
}