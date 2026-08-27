
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppInfoLocalizationCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacyPolicyUrl")]
        public string? PrivacyPolicyUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacyChoicesUrl")]
        public string? PrivacyChoicesUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacyPolicyText")]
        public string? PrivacyPolicyText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="name"></param>
        /// <param name="subtitle"></param>
        /// <param name="privacyPolicyUrl"></param>
        /// <param name="privacyChoicesUrl"></param>
        /// <param name="privacyPolicyText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppInfoLocalizationCreateRequestDataAttributes(
            string locale,
            string name,
            string? subtitle,
            string? privacyPolicyUrl,
            string? privacyChoicesUrl,
            string? privacyPolicyText)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Subtitle = subtitle;
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.PrivacyChoicesUrl = privacyChoicesUrl;
            this.PrivacyPolicyText = privacyPolicyText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppInfoLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppInfoLocalizationCreateRequestDataAttributes()
        {
        }

    }
}