
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceLocalizationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLanguageJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceLanguage? Language { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceLocalizationAttributes" /> class.
        /// </summary>
        /// <param name="language"></param>
        /// <param name="title"></param>
        /// <param name="subtitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceLocalizationAttributes(
            global::AppStoreConnect.AppClipAdvancedExperienceLanguage? language,
            string? title,
            string? subtitle)
        {
            this.Language = language;
            this.Title = title;
            this.Subtitle = subtitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceLocalizationAttributes" /> class.
        /// </summary>
        public AppClipAdvancedExperienceLocalizationAttributes()
        {
        }

    }
}