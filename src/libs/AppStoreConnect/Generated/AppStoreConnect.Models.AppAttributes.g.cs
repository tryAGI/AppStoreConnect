
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessibilityUrl")]
        public string? AccessibilityUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundleId")]
        public string? BundleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        public string? Sku { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryLocale")]
        public string? PrimaryLocale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isOrEverWasMadeForKids")]
        public bool? IsOrEverWasMadeForKids { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionStatusUrl")]
        public string? SubscriptionStatusUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionStatusUrlVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter))]
        public global::AppStoreConnect.SubscriptionStatusUrlVersion? SubscriptionStatusUrlVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionStatusUrlForSandbox")]
        public string? SubscriptionStatusUrlForSandbox { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionStatusUrlVersionForSandbox")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionStatusUrlVersionJsonConverter))]
        public global::AppStoreConnect.SubscriptionStatusUrlVersion? SubscriptionStatusUrlVersionForSandbox { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentRightsDeclaration")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppAttributesContentRightsDeclarationJsonConverter))]
        public global::AppStoreConnect.AppAttributesContentRightsDeclaration? ContentRightsDeclaration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamlinedPurchasingEnabled")]
        public bool? StreamlinedPurchasingEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAttributes" /> class.
        /// </summary>
        /// <param name="accessibilityUrl"></param>
        /// <param name="name"></param>
        /// <param name="bundleId"></param>
        /// <param name="sku"></param>
        /// <param name="primaryLocale"></param>
        /// <param name="isOrEverWasMadeForKids"></param>
        /// <param name="subscriptionStatusUrl"></param>
        /// <param name="subscriptionStatusUrlVersion"></param>
        /// <param name="subscriptionStatusUrlForSandbox"></param>
        /// <param name="subscriptionStatusUrlVersionForSandbox"></param>
        /// <param name="contentRightsDeclaration"></param>
        /// <param name="streamlinedPurchasingEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppAttributes(
            string? accessibilityUrl,
            string? name,
            string? bundleId,
            string? sku,
            string? primaryLocale,
            bool? isOrEverWasMadeForKids,
            string? subscriptionStatusUrl,
            global::AppStoreConnect.SubscriptionStatusUrlVersion? subscriptionStatusUrlVersion,
            string? subscriptionStatusUrlForSandbox,
            global::AppStoreConnect.SubscriptionStatusUrlVersion? subscriptionStatusUrlVersionForSandbox,
            global::AppStoreConnect.AppAttributesContentRightsDeclaration? contentRightsDeclaration,
            bool? streamlinedPurchasingEnabled)
        {
            this.AccessibilityUrl = accessibilityUrl;
            this.Name = name;
            this.BundleId = bundleId;
            this.Sku = sku;
            this.PrimaryLocale = primaryLocale;
            this.IsOrEverWasMadeForKids = isOrEverWasMadeForKids;
            this.SubscriptionStatusUrl = subscriptionStatusUrl;
            this.SubscriptionStatusUrlVersion = subscriptionStatusUrlVersion;
            this.SubscriptionStatusUrlForSandbox = subscriptionStatusUrlForSandbox;
            this.SubscriptionStatusUrlVersionForSandbox = subscriptionStatusUrlVersionForSandbox;
            this.ContentRightsDeclaration = contentRightsDeclaration;
            this.StreamlinedPurchasingEnabled = streamlinedPurchasingEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppAttributes" /> class.
        /// </summary>
        public AppAttributes()
        {
        }

    }
}