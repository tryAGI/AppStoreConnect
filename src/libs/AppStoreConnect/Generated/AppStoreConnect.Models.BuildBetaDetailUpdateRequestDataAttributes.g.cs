
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildBetaDetailUpdateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoNotifyEnabled")]
        public bool? AutoNotifyEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBetaDetailUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="autoNotifyEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildBetaDetailUpdateRequestDataAttributes(
            bool? autoNotifyEnabled)
        {
            this.AutoNotifyEnabled = autoNotifyEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBetaDetailUpdateRequestDataAttributes" /> class.
        /// </summary>
        public BuildBetaDetailUpdateRequestDataAttributes()
        {
        }

    }
}