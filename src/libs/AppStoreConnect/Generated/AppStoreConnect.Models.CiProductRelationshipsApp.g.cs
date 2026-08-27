
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiProductRelationshipsApp
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
        public global::AppStoreConnect.CiProductRelationshipsAppData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiProductRelationshipsApp" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiProductRelationshipsApp(
            global::AppStoreConnect.RelationshipLinks? links,
            global::AppStoreConnect.CiProductRelationshipsAppData? data)
        {
            this.Links = links;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiProductRelationshipsApp" /> class.
        /// </summary>
        public CiProductRelationshipsApp()
        {
        }

    }
}