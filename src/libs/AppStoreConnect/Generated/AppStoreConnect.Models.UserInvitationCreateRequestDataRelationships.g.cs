
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserInvitationCreateRequestDataRelationships
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibleApps")]
        public global::AppStoreConnect.UserInvitationCreateRequestDataRelationshipsVisibleApps? VisibleApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationCreateRequestDataRelationships" /> class.
        /// </summary>
        /// <param name="visibleApps"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInvitationCreateRequestDataRelationships(
            global::AppStoreConnect.UserInvitationCreateRequestDataRelationshipsVisibleApps? visibleApps)
        {
            this.VisibleApps = visibleApps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationCreateRequestDataRelationships" /> class.
        /// </summary>
        public UserInvitationCreateRequestDataRelationships()
        {
        }

    }
}