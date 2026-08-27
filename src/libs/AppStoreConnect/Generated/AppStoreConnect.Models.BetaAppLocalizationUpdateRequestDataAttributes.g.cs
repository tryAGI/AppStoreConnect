
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAppLocalizationUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedbackEmail")]
        public string? FeedbackEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketingUrl")]
        public string? MarketingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacyPolicyUrl")]
        public string? PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tvOsPrivacyPolicy")]
        public string? TvOsPrivacyPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="feedbackEmail"></param>
        /// <param name="marketingUrl"></param>
        /// <param name="privacyPolicyUrl"></param>
        /// <param name="tvOsPrivacyPolicy"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppLocalizationUpdateRequestDataAttributes(
            string? feedbackEmail,
            string? marketingUrl,
            string? privacyPolicyUrl,
            string? tvOsPrivacyPolicy,
            string? description)
        {
            this.FeedbackEmail = feedbackEmail;
            this.MarketingUrl = marketingUrl;
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.TvOsPrivacyPolicy = tvOsPrivacyPolicy;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        public BetaAppLocalizationUpdateRequestDataAttributes()
        {
        }

    }
}