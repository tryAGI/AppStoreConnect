
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ErrorLinksAssociated
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::AppStoreConnect.ErrorLinksAssociatedMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLinksAssociated" /> class.
        /// </summary>
        /// <param name="href"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorLinksAssociated(
            string? href,
            global::AppStoreConnect.ErrorLinksAssociatedMeta? meta)
        {
            this.Href = href;
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorLinksAssociated" /> class.
        /// </summary>
        public ErrorLinksAssociated()
        {
        }

    }
}