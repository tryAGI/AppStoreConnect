
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipDefaultExperienceLocalizationUpdateRequestDataAttributes
    {
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
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="subtitle"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipDefaultExperienceLocalizationUpdateRequestDataAttributes(
            string? subtitle)
        {
            this.Subtitle = subtitle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipDefaultExperienceLocalizationUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppClipDefaultExperienceLocalizationUpdateRequestDataAttributes()
        {
        }

    }
}