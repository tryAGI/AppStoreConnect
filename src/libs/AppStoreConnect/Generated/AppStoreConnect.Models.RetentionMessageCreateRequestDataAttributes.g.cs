
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionMessageCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReferenceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="referenceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionMessageCreateRequestDataAttributes(
            string referenceName)
        {
            this.ReferenceName = referenceName ?? throw new global::System.ArgumentNullException(nameof(referenceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessageCreateRequestDataAttributes" /> class.
        /// </summary>
        public RetentionMessageCreateRequestDataAttributes()
        {
        }

    }
}