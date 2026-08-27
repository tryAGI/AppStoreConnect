
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseVersionRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchase")]
        public global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchase? InAppPurchase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::AppStoreConnect.InAppPurchaseVersionRelationshipsImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::AppStoreConnect.InAppPurchaseVersionRelationshipsImages? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localizations")]
        public global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizations? Localizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseVersionRelationships" /> class.
        /// </summary>
        /// <param name="inAppPurchase"></param>
        /// <param name="image"></param>
        /// <param name="images"></param>
        /// <param name="localizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseVersionRelationships(
            global::AppStoreConnect.InAppPurchaseVersionRelationshipsInAppPurchase? inAppPurchase,
            global::AppStoreConnect.InAppPurchaseVersionRelationshipsImage? image,
            global::AppStoreConnect.InAppPurchaseVersionRelationshipsImages? images,
            global::AppStoreConnect.InAppPurchaseVersionRelationshipsLocalizations? localizations)
        {
            this.InAppPurchase = inAppPurchase;
            this.Image = image;
            this.Images = images;
            this.Localizations = localizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseVersionRelationships" /> class.
        /// </summary>
        public InAppPurchaseVersionRelationships()
        {
        }

    }
}