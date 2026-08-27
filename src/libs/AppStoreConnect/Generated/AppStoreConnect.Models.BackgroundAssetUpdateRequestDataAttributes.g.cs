
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackgroundAssetUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="archived"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackgroundAssetUpdateRequestDataAttributes(
            bool? archived)
        {
            this.Archived = archived;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundAssetUpdateRequestDataAttributes" /> class.
        /// </summary>
        public BackgroundAssetUpdateRequestDataAttributes()
        {
        }

    }
}