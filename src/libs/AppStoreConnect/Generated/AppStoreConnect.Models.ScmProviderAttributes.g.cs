
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ScmProviderAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scmProviderType")]
        public global::AppStoreConnect.ScmProviderType2? ScmProviderType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmProviderAttributes" /> class.
        /// </summary>
        /// <param name="scmProviderType"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScmProviderAttributes(
            global::AppStoreConnect.ScmProviderType2? scmProviderType,
            string? url)
        {
            this.ScmProviderType = scmProviderType;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScmProviderAttributes" /> class.
        /// </summary>
        public ScmProviderAttributes()
        {
        }

    }
}