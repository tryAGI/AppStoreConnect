
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseImageCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchaseImageCreateRequestDataRelationshipsInAppPurchase InAppPurchase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseImageCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseImageCreateRequestDataRelationships(
            global::AppStoreConnect.InAppPurchaseImageCreateRequestDataRelationshipsInAppPurchase inAppPurchase)
        {
            this.InAppPurchase = inAppPurchase ?? throw new global::System.ArgumentNullException(nameof(inAppPurchase));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseImageCreateRequestDataRelationships" /> class.
        /// </summary>
        public InAppPurchaseImageCreateRequestDataRelationships()
        {
        }

    }
}