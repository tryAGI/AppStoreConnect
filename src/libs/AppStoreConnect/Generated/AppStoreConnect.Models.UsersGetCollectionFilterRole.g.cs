
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsersGetCollectionFilterRole
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
    public static class UsersGetCollectionFilterRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetCollectionFilterRole value)
        {
            return value switch
            {
                UsersGetCollectionFilterRole.AccessToReports => "ACCESS_TO_REPORTS",
                UsersGetCollectionFilterRole.AccountHolder => "ACCOUNT_HOLDER",
                UsersGetCollectionFilterRole.Admin => "ADMIN",
                UsersGetCollectionFilterRole.AppManager => "APP_MANAGER",
                UsersGetCollectionFilterRole.CloudManagedAppDistribution => "CLOUD_MANAGED_APP_DISTRIBUTION",
                UsersGetCollectionFilterRole.CloudManagedDeveloperId => "CLOUD_MANAGED_DEVELOPER_ID",
                UsersGetCollectionFilterRole.CreateApps => "CREATE_APPS",
                UsersGetCollectionFilterRole.CustomerSupport => "CUSTOMER_SUPPORT",
                UsersGetCollectionFilterRole.Developer => "DEVELOPER",
                UsersGetCollectionFilterRole.Finance => "FINANCE",
                UsersGetCollectionFilterRole.GenerateIndividualKeys => "GENERATE_INDIVIDUAL_KEYS",
                UsersGetCollectionFilterRole.Marketing => "MARKETING",
                UsersGetCollectionFilterRole.Sales => "SALES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetCollectionFilterRole? ToEnum(string value)
        {
            return value switch
            {
                "ACCESS_TO_REPORTS" => UsersGetCollectionFilterRole.AccessToReports,
                "ACCOUNT_HOLDER" => UsersGetCollectionFilterRole.AccountHolder,
                "ADMIN" => UsersGetCollectionFilterRole.Admin,
                "APP_MANAGER" => UsersGetCollectionFilterRole.AppManager,
                "CLOUD_MANAGED_APP_DISTRIBUTION" => UsersGetCollectionFilterRole.CloudManagedAppDistribution,
                "CLOUD_MANAGED_DEVELOPER_ID" => UsersGetCollectionFilterRole.CloudManagedDeveloperId,
                "CREATE_APPS" => UsersGetCollectionFilterRole.CreateApps,
                "CUSTOMER_SUPPORT" => UsersGetCollectionFilterRole.CustomerSupport,
                "DEVELOPER" => UsersGetCollectionFilterRole.Developer,
                "FINANCE" => UsersGetCollectionFilterRole.Finance,
                "GENERATE_INDIVIDUAL_KEYS" => UsersGetCollectionFilterRole.GenerateIndividualKeys,
                "MARKETING" => UsersGetCollectionFilterRole.Marketing,
                "SALES" => UsersGetCollectionFilterRole.Sales,
                _ => null,
            };
        }
    }
}