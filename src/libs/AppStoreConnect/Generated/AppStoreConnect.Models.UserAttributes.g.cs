
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

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
        /// Initializes a new instance of the <see cref="UserAttributes" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="roles"></param>
        /// <param name="allAppsVisible"></param>
        /// <param name="provisioningAllowed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserAttributes(
            string? username,
            string? firstName,
            string? lastName,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserRole>? roles,
            bool? allAppsVisible,
            bool? provisioningAllowed)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Roles = roles;
            this.AllAppsVisible = allAppsVisible;
            this.ProvisioningAllowed = provisioningAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAttributes" /> class.
        /// </summary>
        public UserAttributes()
        {
        }

    }
}