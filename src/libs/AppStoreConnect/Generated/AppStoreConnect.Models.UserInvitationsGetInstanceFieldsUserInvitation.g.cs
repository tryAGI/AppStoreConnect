
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserInvitationsGetInstanceFieldsUserInvitation
    {
        /// <summary>
        /// 
        /// </summary>
        AllAppsVisible,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        ExpirationDate,
        /// <summary>
        /// 
        /// </summary>
        FirstName,
        /// <summary>
        /// 
        /// </summary>
        LastName,
        /// <summary>
        /// 
        /// </summary>
        ProvisioningAllowed,
        /// <summary>
        /// 
        /// </summary>
        Roles,
        /// <summary>
        /// 
        /// </summary>
        VisibleApps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationsGetInstanceFieldsUserInvitationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationsGetInstanceFieldsUserInvitation value)
        {
            return value switch
            {
                UserInvitationsGetInstanceFieldsUserInvitation.AllAppsVisible => "allAppsVisible",
                UserInvitationsGetInstanceFieldsUserInvitation.Email => "email",
                UserInvitationsGetInstanceFieldsUserInvitation.ExpirationDate => "expirationDate",
                UserInvitationsGetInstanceFieldsUserInvitation.FirstName => "firstName",
                UserInvitationsGetInstanceFieldsUserInvitation.LastName => "lastName",
                UserInvitationsGetInstanceFieldsUserInvitation.ProvisioningAllowed => "provisioningAllowed",
                UserInvitationsGetInstanceFieldsUserInvitation.Roles => "roles",
                UserInvitationsGetInstanceFieldsUserInvitation.VisibleApps => "visibleApps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationsGetInstanceFieldsUserInvitation? ToEnum(string value)
        {
            return value switch
            {
                "allAppsVisible" => UserInvitationsGetInstanceFieldsUserInvitation.AllAppsVisible,
                "email" => UserInvitationsGetInstanceFieldsUserInvitation.Email,
                "expirationDate" => UserInvitationsGetInstanceFieldsUserInvitation.ExpirationDate,
                "firstName" => UserInvitationsGetInstanceFieldsUserInvitation.FirstName,
                "lastName" => UserInvitationsGetInstanceFieldsUserInvitation.LastName,
                "provisioningAllowed" => UserInvitationsGetInstanceFieldsUserInvitation.ProvisioningAllowed,
                "roles" => UserInvitationsGetInstanceFieldsUserInvitation.Roles,
                "visibleApps" => UserInvitationsGetInstanceFieldsUserInvitation.VisibleApps,
                _ => null,
            };
        }
    }
}