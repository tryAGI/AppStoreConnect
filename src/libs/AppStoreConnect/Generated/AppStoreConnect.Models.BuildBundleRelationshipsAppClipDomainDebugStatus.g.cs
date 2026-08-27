
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildBundleRelationshipsAppClipDomainDebugStatus
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::AppStoreConnect.RelationshipLinks? Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleRelationshipsAppClipDomainDebugStatus" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildBundleRelationshipsAppClipDomainDebugStatus(
            global::AppStoreConnect.RelationshipLinks? links,
            global::AppStoreConnect.BuildBundleRelationshipsAppClipDomainDebugStatusData? data)
        {
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildBundleRelationshipsAppClipDomainDebugStatus" /> class.
        /// </summary>
        public BuildBundleRelationshipsAppClipDomainDebugStatus()
        {
        }

    }
}