
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlternativeDistributionKeyAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        public string? PublicKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionKeyAttributes" /> class.
        /// </summary>
        /// <param name="publicKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlternativeDistributionKeyAttributes(
            string? publicKey)
        {
            this.PublicKey = publicKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlternativeDistributionKeyAttributes" /> class.
        /// </summary>
        public AlternativeDistributionKeyAttributes()
        {
        }

    }
}