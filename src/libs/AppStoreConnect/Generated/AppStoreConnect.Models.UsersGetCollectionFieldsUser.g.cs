
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UsersGetCollectionFieldsUser
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
    public static class UsersGetCollectionFieldsUserExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetCollectionFieldsUser value)
        {
            return value switch
            {
                UsersGetCollectionFieldsUser.AllAppsVisible => "allAppsVisible",
                UsersGetCollectionFieldsUser.FirstName => "firstName",
                UsersGetCollectionFieldsUser.LastName => "lastName",
                UsersGetCollectionFieldsUser.ProvisioningAllowed => "provisioningAllowed",
                UsersGetCollectionFieldsUser.Roles => "roles",
                UsersGetCollectionFieldsUser.Username => "username",
                UsersGetCollectionFieldsUser.VisibleApps => "visibleApps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetCollectionFieldsUser? ToEnum(string value)
        {
            return value switch
            {
                "allAppsVisible" => UsersGetCollectionFieldsUser.AllAppsVisible,
                "firstName" => UsersGetCollectionFieldsUser.FirstName,
                "lastName" => UsersGetCollectionFieldsUser.LastName,
                "provisioningAllowed" => UsersGetCollectionFieldsUser.ProvisioningAllowed,
                "roles" => UsersGetCollectionFieldsUser.Roles,
                "username" => UsersGetCollectionFieldsUser.Username,
                "visibleApps" => UsersGetCollectionFieldsUser.VisibleApps,
                _ => null,
            };
        }
    }
}