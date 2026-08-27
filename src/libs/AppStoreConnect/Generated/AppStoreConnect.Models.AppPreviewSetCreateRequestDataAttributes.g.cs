
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppPreviewSetCreateRequestDataAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PreviewTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.PreviewType PreviewType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewSetCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="previewType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPreviewSetCreateRequestDataAttributes(
            global::AppStoreConnect.PreviewType previewType)
        {
            this.PreviewType = previewType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewSetCreateRequestDataAttributes" /> class.
        /// </summary>
        public AppPreviewSetCreateRequestDataAttributes()
        {
        }

    }
}