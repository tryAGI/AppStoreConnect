
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibleApps")]
        public global::AppStoreConnect.UserRelationshipsVisibleApps? VisibleApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRelationships" /> class.
        /// </summary>
        /// <param name="visibleApps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserRelationships(
            global::AppStoreConnect.UserRelationshipsVisibleApps? visibleApps)
        {
            this.VisibleApps = visibleApps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRelationships" /> class.
        /// </summary>
        public UserRelationships()
        {
        }

    }
}