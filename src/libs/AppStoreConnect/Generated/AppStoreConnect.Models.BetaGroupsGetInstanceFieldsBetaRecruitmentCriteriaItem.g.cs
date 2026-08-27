
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem
    {
        /// <summary>
        /// 
        /// </summary>
        DeviceFamilyOsVersionFilters,
        /// <summary>
        /// 
        /// </summary>
        LastModifiedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem value)
        {
            return value switch
            {
                BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem.DeviceFamilyOsVersionFilters => "deviceFamilyOsVersionFilters",
                BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem.LastModifiedDate => "lastModifiedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem? ToEnum(string value)
        {
            return value switch
            {
                "deviceFamilyOsVersionFilters" => BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem.DeviceFamilyOsVersionFilters,
                "lastModifiedDate" => BetaGroupsGetInstanceFieldsBetaRecruitmentCriteriaItem.LastModifiedDate,
                _ => null,
            };
        }
    }
}