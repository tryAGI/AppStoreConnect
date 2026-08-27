
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestData Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreate>? Included { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequest" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="included"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceCreateRequest(
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestData data,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAdvancedExperienceLocalizationInlineCreate>? included)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Included = included;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequest" /> class.
        /// </summary>
        public AppClipAdvancedExperienceCreateRequest()
        {
        }

    }
}