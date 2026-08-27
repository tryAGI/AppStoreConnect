
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppPreviewCreateRequestDataRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPreviewSet")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.AppPreviewCreateRequestDataRelationshipsAppPreviewSet AppPreviewSet { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="appPreviewSet"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppPreviewCreateRequestDataRelationships(
            global::AppStoreConnect.AppPreviewCreateRequestDataRelationshipsAppPreviewSet appPreviewSet)
        {
            this.AppPreviewSet = appPreviewSet ?? throw new global::System.ArgumentNullException(nameof(appPreviewSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppPreviewCreateRequestDataRelationships" /> class.
        /// </summary>
        public AppPreviewCreateRequestDataRelationships()
        {
        }

    }
}