
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem
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
    public static class BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem value)
        {
            return value switch
            {
                BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem.DeviceFamilyOsVersionFilters => "deviceFamilyOsVersionFilters",
                BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem.LastModifiedDate => "lastModifiedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem? ToEnum(string value)
        {
            return value switch
            {
                "deviceFamilyOsVersionFilters" => BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem.DeviceFamilyOsVersionFilters,
                "lastModifiedDate" => BetaGroupsGetCollectionFieldsBetaRecruitmentCriteriaItem.LastModifiedDate,
                _ => null,
            };
        }
    }
}