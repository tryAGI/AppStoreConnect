
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipDefaultExperienceLocalizationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

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
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="subtitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipDefaultExperienceLocalizationAttributes(
            string? locale,
            string? subtitle)
        {
            this.Locale = locale;
            this.Subtitle = subtitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationAttributes" /> class.
        /// </summary>
        public AppClipDefaultExperienceLocalizationAttributes()
        {
        }

    }
}