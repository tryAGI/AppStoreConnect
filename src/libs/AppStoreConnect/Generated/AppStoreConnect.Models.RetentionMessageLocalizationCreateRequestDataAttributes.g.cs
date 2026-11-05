
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionMessageLocalizationCreateRequestDataAttributes
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
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        public string? Header { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="header"></param>
        /// <param name="body"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionMessageLocalizationCreateRequestDataAttributes(
            string locale,
            string? header,
            string? body)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Header = header;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        public RetentionMessageLocalizationCreateRequestDataAttributes()
        {
        }

    }
}