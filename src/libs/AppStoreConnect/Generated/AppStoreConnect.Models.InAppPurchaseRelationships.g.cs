
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::AppStoreConnect.InAppPurchaseRelationshipsApps? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseRelationships" /> class.
        /// </summary>
        /// <param name="apps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseRelationships(
            global::AppStoreConnect.InAppPurchaseRelationshipsApps? apps)
        {
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseRelationships" /> class.
        /// </summary>
        public InAppPurchaseRelationships()
        {
        }

    }
}