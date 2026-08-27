
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppCustomProductPageLocalizationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionalText")]
        public string? PromotionalText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="promotionalText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppCustomProductPageLocalizationAttributes(
            string? locale,
            string? promotionalText)
        {
            this.Locale = locale;
            this.PromotionalText = promotionalText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppCustomProductPageLocalizationAttributes" /> class.
        /// </summary>
        public AppCustomProductPageLocalizationAttributes()
        {
        }

    }
}