
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseV2Relationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseLocalizations")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizations? InAppPurchaseLocalizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricePoints")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePoints? PricePoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsContent? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appStoreReviewScreenshot")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshot? AppStoreReviewScreenshot { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotedPurchase")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchase? PromotedPurchase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iapPriceSchedule")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceSchedule? IapPriceSchedule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inAppPurchaseAvailability")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailability? InAppPurchaseAvailability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsImages? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offerCodes")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodes? OfferCodes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::AppStoreConnect.InAppPurchaseV2RelationshipsVersions? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseV2Relationships" /> class.
        /// </summary>
        /// <param name="inAppPurchaseLocalizations"></param>
        /// <param name="pricePoints"></param>
        /// <param name="content"></param>
        /// <param name="appStoreReviewScreenshot"></param>
        /// <param name="promotedPurchase"></param>
        /// <param name="iapPriceSchedule"></param>
        /// <param name="inAppPurchaseAvailability"></param>
        /// <param name="images"></param>
        /// <param name="offerCodes"></param>
        /// <param name="versions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseV2Relationships(
            global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseLocalizations? inAppPurchaseLocalizations,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsPricePoints? pricePoints,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsContent? content,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsAppStoreReviewScreenshot? appStoreReviewScreenshot,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsPromotedPurchase? promotedPurchase,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsIapPriceSchedule? iapPriceSchedule,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsInAppPurchaseAvailability? inAppPurchaseAvailability,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsImages? images,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsOfferCodes? offerCodes,
            global::AppStoreConnect.InAppPurchaseV2RelationshipsVersions? versions)
        {
            this.InAppPurchaseLocalizations = inAppPurchaseLocalizations;
            this.PricePoints = pricePoints;
            this.Content = content;
            this.AppStoreReviewScreenshot = appStoreReviewScreenshot;
            this.PromotedPurchase = promotedPurchase;
            this.IapPriceSchedule = iapPriceSchedule;
            this.InAppPurchaseAvailability = inAppPurchaseAvailability;
            this.Images = images;
            this.OfferCodes = offerCodes;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseV2Relationships" /> class.
        /// </summary>
        public InAppPurchaseV2Relationships()
        {
        }

    }
}