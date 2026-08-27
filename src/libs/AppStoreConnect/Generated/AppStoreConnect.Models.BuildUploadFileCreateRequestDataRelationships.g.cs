
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildUploadFileCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buildUpload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUpload BuildUpload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadFileCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="buildUpload"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildUploadFileCreateRequestDataRelationships(
            global::AppStoreConnect.BuildUploadFileCreateRequestDataRelationshipsBuildUpload buildUpload)
        {
            this.BuildUpload = buildUpload ?? throw new global::System.ArgumentNullException(nameof(buildUpload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadFileCreateRequestDataRelationships" /> class.
        /// </summary>
        public BuildUploadFileCreateRequestDataRelationships()
        {
        }

    }
}