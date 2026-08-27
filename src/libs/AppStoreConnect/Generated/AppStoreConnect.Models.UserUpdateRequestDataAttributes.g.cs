
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.UserRole>? Roles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allAppsVisible")]
        public bool? AllAppsVisible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provisioningAllowed")]
        public bool? ProvisioningAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="roles"></param>
        /// <param name="allAppsVisible"></param>
        /// <param name="provisioningAllowed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserUpdateRequestDataAttributes(
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserRole>? roles,
            bool? allAppsVisible,
            bool? provisioningAllowed)
        {
            this.Roles = roles;
            this.AllAppsVisible = allAppsVisible;
            this.ProvisioningAllowed = provisioningAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserUpdateRequestDataAttributes" /> class.
        /// </summary>
        public UserUpdateRequestDataAttributes()
        {
        }

    }
}