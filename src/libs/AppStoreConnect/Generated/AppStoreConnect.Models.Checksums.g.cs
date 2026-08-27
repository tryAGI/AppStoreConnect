
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Checksums
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::AppStoreConnect.ChecksumsFile? File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("composite")]
        public global::AppStoreConnect.ChecksumsComposite? Composite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Checksums" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="composite"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Checksums(
            global::AppStoreConnect.ChecksumsFile? file,
            global::AppStoreConnect.ChecksumsComposite? composite)
        {
            this.File = file;
            this.Composite = composite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Checksums" /> class.
        /// </summary>
        public Checksums()
        {
        }

    }
}