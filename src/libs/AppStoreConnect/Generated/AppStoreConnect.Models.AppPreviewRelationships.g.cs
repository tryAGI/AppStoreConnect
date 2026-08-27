
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppPreviewRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPreviewSet")]
        public global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSet? AppPreviewSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewRelationships" /> class.
        /// </summary>
        /// <param name="appPreviewSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPreviewRelationships(
            global::AppStoreConnect.AppPreviewRelationshipsAppPreviewSet? appPreviewSet)
        {
            this.AppPreviewSet = appPreviewSet;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewRelationships" /> class.
        /// </summary>
        public AppPreviewRelationships()
        {
        }

    }
}