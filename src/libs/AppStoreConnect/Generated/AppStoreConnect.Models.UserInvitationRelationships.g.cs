
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserInvitationRelationships
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibleApps")]
        public global::AppStoreConnect.UserInvitationRelationshipsVisibleApps? VisibleApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationRelationships" /> class.
        /// </summary>
        /// <param name="visibleApps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInvitationRelationships(
            global::AppStoreConnect.UserInvitationRelationshipsVisibleApps? visibleApps)
        {
            this.VisibleApps = visibleApps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationRelationships" /> class.
        /// </summary>
        public UserInvitationRelationships()
        {
        }

    }
}