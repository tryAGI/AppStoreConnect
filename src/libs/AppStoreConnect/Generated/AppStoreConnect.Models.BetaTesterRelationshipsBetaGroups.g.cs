
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaTesterRelationshipsBetaGroups
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::AppStoreConnect.RelationshipLinks? Links { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::AppStoreConnect.PagingInformation? Meta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterRelationshipsBetaGroups" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="meta"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTesterRelationshipsBetaGroups(
            global::AppStoreConnect.RelationshipLinks? links,
            global::AppStoreConnect.PagingInformation? meta,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaTesterRelationshipsBetaGroupsDataItem>? data)
        {
            this.Links = links;
            this.Meta = meta;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTesterRelationshipsBetaGroups" /> class.
        /// </summary>
        public BetaTesterRelationshipsBetaGroups()
        {
        }

    }
}