
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseImageRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchase")]
        public global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchase? InAppPurchase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseImageRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseImageRelationships(
            global::AppStoreConnect.InAppPurchaseImageRelationshipsInAppPurchase? inAppPurchase)
        {
            this.InAppPurchase = inAppPurchase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseImageRelationships" /> class.
        /// </summary>
        public InAppPurchaseImageRelationships()
        {
        }

    }
}