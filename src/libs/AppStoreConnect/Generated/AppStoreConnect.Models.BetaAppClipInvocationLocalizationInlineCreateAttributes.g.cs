
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaAppClipInvocationLocalizationInlineCreateAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationLocalizationInlineCreateAttributes" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="locale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAppClipInvocationLocalizationInlineCreateAttributes(
            string title,
            string locale)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAppClipInvocationLocalizationInlineCreateAttributes" /> class.
        /// </summary>
        public BetaAppClipInvocationLocalizationInlineCreateAttributes()
        {
        }

    }
}