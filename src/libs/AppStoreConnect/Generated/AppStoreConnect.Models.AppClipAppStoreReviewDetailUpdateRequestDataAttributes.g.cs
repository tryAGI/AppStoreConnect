
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAppStoreReviewDetailUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationUrls")]
        public global::System.Collections.Generic.IList<string>? InvocationUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAppStoreReviewDetailUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="invocationUrls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAppStoreReviewDetailUpdateRequestDataAttributes(
            global::System.Collections.Generic.IList<string>? invocationUrls)
        {
            this.InvocationUrls = invocationUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAppStoreReviewDetailUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppClipAppStoreReviewDetailUpdateRequestDataAttributes()
        {
        }

    }
}