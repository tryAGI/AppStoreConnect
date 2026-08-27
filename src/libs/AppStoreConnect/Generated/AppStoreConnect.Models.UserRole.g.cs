
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserRole
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
    public static class UserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserRole value)
        {
            return value switch
            {
                UserRole.AccessToReports => "ACCESS_TO_REPORTS",
                UserRole.AccountHolder => "ACCOUNT_HOLDER",
                UserRole.Admin => "ADMIN",
                UserRole.AppManager => "APP_MANAGER",
                UserRole.CloudManagedAppDistribution => "CLOUD_MANAGED_APP_DISTRIBUTION",
                UserRole.CloudManagedDeveloperId => "CLOUD_MANAGED_DEVELOPER_ID",
                UserRole.CreateApps => "CREATE_APPS",
                UserRole.CustomerSupport => "CUSTOMER_SUPPORT",
                UserRole.Developer => "DEVELOPER",
                UserRole.Finance => "FINANCE",
                UserRole.GenerateIndividualKeys => "GENERATE_INDIVIDUAL_KEYS",
                UserRole.Marketing => "MARKETING",
                UserRole.Sales => "SALES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserRole? ToEnum(string value)
        {
            return value switch
            {
                "ACCESS_TO_REPORTS" => UserRole.AccessToReports,
                "ACCOUNT_HOLDER" => UserRole.AccountHolder,
                "ADMIN" => UserRole.Admin,
                "APP_MANAGER" => UserRole.AppManager,
                "CLOUD_MANAGED_APP_DISTRIBUTION" => UserRole.CloudManagedAppDistribution,
                "CLOUD_MANAGED_DEVELOPER_ID" => UserRole.CloudManagedDeveloperId,
                "CREATE_APPS" => UserRole.CreateApps,
                "CUSTOMER_SUPPORT" => UserRole.CustomerSupport,
                "DEVELOPER" => UserRole.Developer,
                "FINANCE" => UserRole.Finance,
                "GENERATE_INDIVIDUAL_KEYS" => UserRole.GenerateIndividualKeys,
                "MARKETING" => UserRole.Marketing,
                "SALES" => UserRole.Sales,
                _ => null,
            };
        }
    }
}