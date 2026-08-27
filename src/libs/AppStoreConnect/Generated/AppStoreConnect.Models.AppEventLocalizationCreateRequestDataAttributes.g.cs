
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppEventLocalizationCreateRequestDataAttributes
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
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shortDescription")]
        public string? ShortDescription { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longDescription")]
        public string? LongDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="name"></param>
        /// <param name="shortDescription"></param>
        /// <param name="longDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppEventLocalizationCreateRequestDataAttributes(
            string locale,
            string? name,
            string? shortDescription,
            string? longDescription)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Name = name;
            this.ShortDescription = shortDescription;
            this.LongDescription = longDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppEventLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppEventLocalizationCreateRequestDataAttributes()
        {
        }

    }
}