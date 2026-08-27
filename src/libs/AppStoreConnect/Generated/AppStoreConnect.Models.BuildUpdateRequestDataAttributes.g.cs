
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usesNonExemptEncryption")]
        public bool? UsesNonExemptEncryption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="expired"></param>
        /// <param name="usesNonExemptEncryption"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildUpdateRequestDataAttributes(
            bool? expired,
            bool? usesNonExemptEncryption)
        {
            this.Expired = expired;
            this.UsesNonExemptEncryption = usesNonExemptEncryption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUpdateRequestDataAttributes" /> class.
        /// </summary>
        public BuildUpdateRequestDataAttributes()
        {
        }

    }
}