
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReviewSubmissionItemUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        public bool? Resolved { get; set; }

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
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="resolved"></param>
        /// <param name="removed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReviewSubmissionItemUpdateRequestDataAttributes(
            bool? resolved,
            bool? removed)
        {
            this.Resolved = resolved;
            this.Removed = removed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReviewSubmissionItemUpdateRequestDataAttributes" /> class.
        /// </summary>
        public ReviewSubmissionItemUpdateRequestDataAttributes()
        {
        }

    }
}