
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MerchantIdAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantIdAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="identifier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MerchantIdAttributes(
            string? name,
            string? identifier)
        {
            this.Name = name;
            this.Identifier = identifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantIdAttributes" /> class.
        /// </summary>
        public MerchantIdAttributes()
        {
        }

    }
}