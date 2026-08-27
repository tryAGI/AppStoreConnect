
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaBuildLocalizationCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsNew")]
        public string? WhatsNew { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="whatsNew"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBuildLocalizationCreateRequestDataAttributes(
            string locale,
            string? whatsNew)
        {
            this.WhatsNew = whatsNew;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBuildLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        public BetaBuildLocalizationCreateRequestDataAttributes()
        {
        }

    }
}