
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InAppPurchaseLocalizationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseV2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.InAppPurchaseLocalizationCreateRequestDataRelationshipsInAppPurchaseV2 InAppPurchaseV2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchaseV2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseLocalizationCreateRequestDataRelationships(
            global::AppStoreConnect.InAppPurchaseLocalizationCreateRequestDataRelationshipsInAppPurchaseV2 inAppPurchaseV2)
        {
            this.InAppPurchaseV2 = inAppPurchaseV2 ?? throw new global::System.ArgumentNullException(nameof(inAppPurchaseV2));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseLocalizationCreateRequestDataRelationships" /> class.
        /// </summary>
        public InAppPurchaseLocalizationCreateRequestDataRelationships()
        {
        }

    }
}