
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RelationshipLinks
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        public string? Self { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("related")]
        public string? Related { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="related"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelationshipLinks(
            string? self,
            string? related)
        {
            this.Self = self;
            this.Related = related;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelationshipLinks" /> class.
        /// </summary>
        public RelationshipLinks()
        {
        }

    }
}