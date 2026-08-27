
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption
    {
        /// <summary>
        /// 
        /// </summary>
        DeviceFamilyOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption value)
        {
            return value switch
            {
                BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption.DeviceFamilyOsVersions => "deviceFamilyOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption? ToEnum(string value)
        {
            return value switch
            {
                "deviceFamilyOsVersions" => BetaRecruitmentCriterionOptionsGetCollectionFieldsBetaRecruitmentCriterionOption.DeviceFamilyOsVersions,
                _ => null,
            };
        }
    }
}