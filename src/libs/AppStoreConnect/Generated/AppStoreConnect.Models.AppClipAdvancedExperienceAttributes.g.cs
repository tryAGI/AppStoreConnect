
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link")]
        public string? Link { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesStatusJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesStatus? Status { get; set; }

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
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlace? Place { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesPlaceStatusJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceStatus? PlaceStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("businessCategory")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceAttributesBusinessCategoryJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceAttributesBusinessCategory? BusinessCategory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultLanguage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLanguageJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceLanguage? DefaultLanguage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributes" /> class.
        /// </summary>
        /// <param name="link"></param>
        /// <param name="version"></param>
        /// <param name="status"></param>
        /// <param name="action"></param>
        /// <param name="isPoweredBy"></param>
        /// <param name="place"></param>
        /// <param name="placeStatus"></param>
        /// <param name="businessCategory"></param>
        /// <param name="defaultLanguage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceAttributes(
            string? link,
            int? version,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesStatus? status,
            global::AppStoreConnect.AppClipAction? action,
            bool? isPoweredBy,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlace? place,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesPlaceStatus? placeStatus,
            global::AppStoreConnect.AppClipAdvancedExperienceAttributesBusinessCategory? businessCategory,
            global::AppStoreConnect.AppClipAdvancedExperienceLanguage? defaultLanguage)
        {
            this.Link = link;
            this.Version = version;
            this.Status = status;
            this.Action = action;
            this.IsPoweredBy = isPoweredBy;
            this.Place = place;
            this.PlaceStatus = placeStatus;
            this.BusinessCategory = businessCategory;
            this.DefaultLanguage = defaultLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceAttributes" /> class.
        /// </summary>
        public AppClipAdvancedExperienceAttributes()
        {
        }

    }
}