
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserInvitationAttributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationDate")]
        public global::System.DateTime? ExpirationDate { get; set; }

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
        /// Initializes a new instance of the <see cref="UserInvitationAttributes" /> class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="expirationDate"></param>
        /// <param name="roles"></param>
        /// <param name="allAppsVisible"></param>
        /// <param name="provisioningAllowed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInvitationAttributes(
            string? email,
            string? firstName,
            string? lastName,
            global::System.DateTime? expirationDate,
            global::System.Collections.Generic.IList<global::AppStoreConnect.UserRole>? roles,
            bool? allAppsVisible,
            bool? provisioningAllowed)
        {
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ExpirationDate = expirationDate;
            this.Roles = roles;
            this.AllAppsVisible = allAppsVisible;
            this.ProvisioningAllowed = provisioningAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationAttributes" /> class.
        /// </summary>
        public UserInvitationAttributes()
        {
        }

    }
}