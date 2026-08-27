
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlternativeDistributionKeyCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionKeyCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="publicKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionKeyCreateRequestDataAttributes(
            string publicKey)
        {
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionKeyCreateRequestDataAttributes" /> class.
        /// </summary>
        public AlternativeDistributionKeyCreateRequestDataAttributes()
        {
        }

    }
}