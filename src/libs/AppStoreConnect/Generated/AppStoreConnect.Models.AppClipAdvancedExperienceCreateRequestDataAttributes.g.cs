
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Link { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipActionJsonConverter))]
        public global::AppStoreConnect.AppClipAction? Action { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPoweredBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPoweredBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("place")]
        public global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlace? Place { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("businessCategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategoryJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory? BusinessCategory { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultLanguage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLanguageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipAdvancedExperienceLanguage DefaultLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="link"></param>
        /// <param name="isPoweredBy"></param>
        /// <param name="defaultLanguage"></param>
        /// <param name="action"></param>
        /// <param name="place"></param>
        /// <param name="businessCategory"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceCreateRequestDataAttributes(
            string link,
            bool isPoweredBy,
            global::AppStoreConnect.AppClipAdvancedExperienceLanguage defaultLanguage,
            global::AppStoreConnect.AppClipAction? action,
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlace? place,
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesBusinessCategory? businessCategory)
        {
            this.Link = link ?? throw new global::System.ArgumentNullException(nameof(link));
            this.Action = action;
            this.IsPoweredBy = isPoweredBy;
            this.Place = place;
            this.BusinessCategory = businessCategory;
            this.DefaultLanguage = defaultLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppClipAdvancedExperienceCreateRequestDataAttributes()
        {
        }

    }
}