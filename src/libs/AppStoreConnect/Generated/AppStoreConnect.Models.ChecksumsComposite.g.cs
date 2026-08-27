
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChecksumsComposite
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        public string? Hash { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.ChecksumsCompositeAlgorithmJsonConverter))]
        public global::AppStoreConnect.ChecksumsCompositeAlgorithm? Algorithm { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksumsComposite" /> class.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="algorithm"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChecksumsComposite(
            string? hash,
            global::AppStoreConnect.ChecksumsCompositeAlgorithm? algorithm)
        {
            this.Hash = hash;
            this.Algorithm = algorithm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksumsComposite" /> class.
        /// </summary>
        public ChecksumsComposite()
        {
        }

    }
}