
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceUpdateRequestDataAttributes
    {
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
        public bool? IsPoweredBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("place")]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlace? Place { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("businessCategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategoryJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory? BusinessCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultLanguage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLanguageJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceLanguage? DefaultLanguage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed")]
        public bool? Removed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="isPoweredBy"></param>
        /// <param name="place"></param>
        /// <param name="businessCategory"></param>
        /// <param name="defaultLanguage"></param>
        /// <param name="removed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceUpdateRequestDataAttributes(
            global::AppStoreConnect.AppClipAction? action,
            bool? isPoweredBy,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesPlace? place,
            global::AppStoreConnect.AppClipAdvancedExperienceUpdateRequestDataAttributesBusinessCategory? businessCategory,
            global::AppStoreConnect.AppClipAdvancedExperienceLanguage? defaultLanguage,
            bool? removed)
        {
            this.Action = action;
            this.IsPoweredBy = isPoweredBy;
            this.Place = place;
            this.BusinessCategory = businessCategory;
            this.DefaultLanguage = defaultLanguage;
            this.Removed = removed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppClipAdvancedExperienceUpdateRequestDataAttributes()
        {
        }

    }
}