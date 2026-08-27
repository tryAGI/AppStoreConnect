
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomerReviewSummarizationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewSummarizationAttributes" /> class.
        /// </summary>
        /// <param name="createdDate"></param>
        /// <param name="locale"></param>
        /// <param name="platform"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomerReviewSummarizationAttributes(
            global::System.DateTime? createdDate,
            string? locale,
            global::AppStoreConnect.Platform? platform,
            string? text)
        {
            this.CreatedDate = createdDate;
            this.Locale = locale;
            this.Platform = platform;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerReviewSummarizationAttributes" /> class.
        /// </summary>
        public CustomerReviewSummarizationAttributes()
        {
        }

    }
}