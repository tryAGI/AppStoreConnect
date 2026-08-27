
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserInvitationsGetCollectionFilterRole
    {
        /// <summary>
        ///
        /// </summary>
        AccessToReports,
        /// <summary>
        ///
        /// </summary>
        AccountHolder,
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        AppManager,
        /// <summary>
        ///
        /// </summary>
        CloudManagedAppDistribution,
        /// <summary>
        ///
        /// </summary>
        CloudManagedDeveloperId,
        /// <summary>
        ///
        /// </summary>
        CreateApps,
        /// <summary>
        ///
        /// </summary>
        CustomerSupport,
        /// <summary>
        ///
        /// </summary>
        Developer,
        /// <summary>
        ///
        /// </summary>
        Finance,
        /// <summary>
        ///
        /// </summary>
        GenerateIndividualKeys,
        /// <summary>
        ///
        /// </summary>
        Marketing,
        /// <summary>
        ///
        /// </summary>
        Sales,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationsGetCollectionFilterRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationsGetCollectionFilterRole value)
        {
            return value switch
            {
                UserInvitationsGetCollectionFilterRole.AccessToReports => "ACCESS_TO_REPORTS",
                UserInvitationsGetCollectionFilterRole.AccountHolder => "ACCOUNT_HOLDER",
                UserInvitationsGetCollectionFilterRole.Admin => "ADMIN",
                UserInvitationsGetCollectionFilterRole.AppManager => "APP_MANAGER",
                UserInvitationsGetCollectionFilterRole.CloudManagedAppDistribution => "CLOUD_MANAGED_APP_DISTRIBUTION",
                UserInvitationsGetCollectionFilterRole.CloudManagedDeveloperId => "CLOUD_MANAGED_DEVELOPER_ID",
                UserInvitationsGetCollectionFilterRole.CreateApps => "CREATE_APPS",
                UserInvitationsGetCollectionFilterRole.CustomerSupport => "CUSTOMER_SUPPORT",
                UserInvitationsGetCollectionFilterRole.Developer => "DEVELOPER",
                UserInvitationsGetCollectionFilterRole.Finance => "FINANCE",
                UserInvitationsGetCollectionFilterRole.GenerateIndividualKeys => "GENERATE_INDIVIDUAL_KEYS",
                UserInvitationsGetCollectionFilterRole.Marketing => "MARKETING",
                UserInvitationsGetCollectionFilterRole.Sales => "SALES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationsGetCollectionFilterRole? ToEnum(string value)
        {
            return value switch
            {
                "ACCESS_TO_REPORTS" => UserInvitationsGetCollectionFilterRole.AccessToReports,
                "ACCOUNT_HOLDER" => UserInvitationsGetCollectionFilterRole.AccountHolder,
                "ADMIN" => UserInvitationsGetCollectionFilterRole.Admin,
                "APP_MANAGER" => UserInvitationsGetCollectionFilterRole.AppManager,
                "CLOUD_MANAGED_APP_DISTRIBUTION" => UserInvitationsGetCollectionFilterRole.CloudManagedAppDistribution,
                "CLOUD_MANAGED_DEVELOPER_ID" => UserInvitationsGetCollectionFilterRole.CloudManagedDeveloperId,
                "CREATE_APPS" => UserInvitationsGetCollectionFilterRole.CreateApps,
                "CUSTOMER_SUPPORT" => UserInvitationsGetCollectionFilterRole.CustomerSupport,
                "DEVELOPER" => UserInvitationsGetCollectionFilterRole.Developer,
                "FINANCE" => UserInvitationsGetCollectionFilterRole.Finance,
                "GENERATE_INDIVIDUAL_KEYS" => UserInvitationsGetCollectionFilterRole.GenerateIndividualKeys,
                "MARKETING" => UserInvitationsGetCollectionFilterRole.Marketing,
                "SALES" => UserInvitationsGetCollectionFilterRole.Sales,
                _ => null,
            };
        }
    }
}