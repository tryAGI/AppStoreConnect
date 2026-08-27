
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupsBetaRecruitmentCriteriaGetToOneRelatedFieldsBetaRecruitmentCriteriaItem
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
    public static class BetaGroupsBetaRecruitmentCriteriaGetToOneRelatedFieldsBetaRecruitmentCriteriaItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupsBetaRecruitmentCriteriaGetToOneRelatedFieldsBetaRecruitmentCriteriaItem value)
        {
            return value switch
            {
                BetaGroupsBetaRecruitmentCriteriaGetToOneRelatedFieldsBetaRecruitmentCriteriaItem.DeviceFamilyOsVersionFilters => "deviceFamilyOsVersionFilters",
                BetaGroupsBetaRecruitmentCriteriaGetToOneRelatedFieldsBetaRecruitmentCriteriaItem.LastModifiedDate => "lastModifiedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupsBetaRecruitmentCriteriaGetToOneRelatedFieldsBetaRecruitmentCriteriaItem? ToEnum(string value)
        {
            return value switch
            {
                "deviceFamilyOsVersionFilters" => BetaGroupsBetaRecruitmentCriteriaGetToOneRelatedFieldsBetaRecruitmentCriteriaItem.DeviceFamilyOsVersionFilters,
                "lastModifiedDate" => BetaGroupsBetaRecruitmentCriteriaGetToOneRelatedFieldsBetaRecruitmentCriteriaItem.LastModifiedDate,
                _ => null,
            };
        }
    }
}