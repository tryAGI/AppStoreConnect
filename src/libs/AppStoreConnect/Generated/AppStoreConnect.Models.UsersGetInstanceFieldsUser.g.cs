
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsersGetInstanceFieldsUser
    {
        /// <summary>
        /// 
        /// </summary>
        AllAppsVisible,
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
        Username,
        /// <summary>
        /// 
        /// </summary>
        VisibleApps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersGetInstanceFieldsUserExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetInstanceFieldsUser value)
        {
            return value switch
            {
                UsersGetInstanceFieldsUser.AllAppsVisible => "allAppsVisible",
                UsersGetInstanceFieldsUser.FirstName => "firstName",
                UsersGetInstanceFieldsUser.LastName => "lastName",
                UsersGetInstanceFieldsUser.ProvisioningAllowed => "provisioningAllowed",
                UsersGetInstanceFieldsUser.Roles => "roles",
                UsersGetInstanceFieldsUser.Username => "username",
                UsersGetInstanceFieldsUser.VisibleApps => "visibleApps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetInstanceFieldsUser? ToEnum(string value)
        {
            return value switch
            {
                "allAppsVisible" => UsersGetInstanceFieldsUser.AllAppsVisible,
                "firstName" => UsersGetInstanceFieldsUser.FirstName,
                "lastName" => UsersGetInstanceFieldsUser.LastName,
                "provisioningAllowed" => UsersGetInstanceFieldsUser.ProvisioningAllowed,
                "roles" => UsersGetInstanceFieldsUser.Roles,
                "username" => UsersGetInstanceFieldsUser.Username,
                "visibleApps" => UsersGetInstanceFieldsUser.VisibleApps,
                _ => null,
            };
        }
    }
}