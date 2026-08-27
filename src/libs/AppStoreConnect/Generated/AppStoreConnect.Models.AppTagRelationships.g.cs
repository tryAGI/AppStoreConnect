
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppTagRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("territories")]
        public global::AppStoreConnect.AppTagRelationshipsTerritories? Territories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppTagRelationships" /> class.
        /// </summary>
        /// <param name="territories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppTagRelationships(
            global::AppStoreConnect.AppTagRelationshipsTerritories? territories)
        {
            this.Territories = territories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppTagRelationships" /> class.
        /// </summary>
        public AppTagRelationships()
        {
        }

    }
}