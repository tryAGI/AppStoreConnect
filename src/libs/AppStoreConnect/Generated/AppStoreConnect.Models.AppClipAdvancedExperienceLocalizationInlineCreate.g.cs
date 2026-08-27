
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceLocalizationInlineCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceLocalizationInlineCreateTypeJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateAttributes? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceLocalizationInlineCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceLocalizationInlineCreate(
            global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateType type,
            string? id,
            global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreateAttributes? attributes)
        {
            this.Type = type;
            this.Id = id;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceLocalizationInlineCreate" /> class.
        /// </summary>
        public AppClipAdvancedExperienceLocalizationInlineCreate()
        {
        }

    }
}