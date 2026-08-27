
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PagedDocumentLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Self { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first")]
        public string? First { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedDocumentLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="first"></param>
        /// <param name="next"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagedDocumentLinks(
            string self,
            string? first,
            string? next)
        {
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
            this.First = first;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedDocumentLinks" /> class.
        /// </summary>
        public PagedDocumentLinks()
        {
        }

    }
}