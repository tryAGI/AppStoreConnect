
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserInvitationsGetCollectionFieldsUserInvitation
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
    public static class UserInvitationsGetCollectionFieldsUserInvitationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationsGetCollectionFieldsUserInvitation value)
        {
            return value switch
            {
                UserInvitationsGetCollectionFieldsUserInvitation.AllAppsVisible => "allAppsVisible",
                UserInvitationsGetCollectionFieldsUserInvitation.Email => "email",
                UserInvitationsGetCollectionFieldsUserInvitation.ExpirationDate => "expirationDate",
                UserInvitationsGetCollectionFieldsUserInvitation.FirstName => "firstName",
                UserInvitationsGetCollectionFieldsUserInvitation.LastName => "lastName",
                UserInvitationsGetCollectionFieldsUserInvitation.ProvisioningAllowed => "provisioningAllowed",
                UserInvitationsGetCollectionFieldsUserInvitation.Roles => "roles",
                UserInvitationsGetCollectionFieldsUserInvitation.VisibleApps => "visibleApps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationsGetCollectionFieldsUserInvitation? ToEnum(string value)
        {
            return value switch
            {
                "allAppsVisible" => UserInvitationsGetCollectionFieldsUserInvitation.AllAppsVisible,
                "email" => UserInvitationsGetCollectionFieldsUserInvitation.Email,
                "expirationDate" => UserInvitationsGetCollectionFieldsUserInvitation.ExpirationDate,
                "firstName" => UserInvitationsGetCollectionFieldsUserInvitation.FirstName,
                "lastName" => UserInvitationsGetCollectionFieldsUserInvitation.LastName,
                "provisioningAllowed" => UserInvitationsGetCollectionFieldsUserInvitation.ProvisioningAllowed,
                "roles" => UserInvitationsGetCollectionFieldsUserInvitation.Roles,
                "visibleApps" => UserInvitationsGetCollectionFieldsUserInvitation.VisibleApps,
                _ => null,
            };
        }
    }
}