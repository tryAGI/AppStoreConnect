
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppStoreVersionLocalizationUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public string? Keywords { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketingUrl")]
        public string? MarketingUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionalText")]
        public string? PromotionalText { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportUrl")]
        public string? SupportUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsNew")]
        public string? WhatsNew { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="keywords"></param>
        /// <param name="marketingUrl"></param>
        /// <param name="promotionalText"></param>
        /// <param name="supportUrl"></param>
        /// <param name="whatsNew"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppStoreVersionLocalizationUpdateRequestDataAttributes(
            string? description,
            string? keywords,
            string? marketingUrl,
            string? promotionalText,
            string? supportUrl,
            string? whatsNew)
        {
            this.Description = description;
            this.Keywords = keywords;
            this.MarketingUrl = marketingUrl;
            this.PromotionalText = promotionalText;
            this.SupportUrl = supportUrl;
            this.WhatsNew = whatsNew;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreVersionLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppStoreVersionLocalizationUpdateRequestDataAttributes()
        {
        }

    }
}