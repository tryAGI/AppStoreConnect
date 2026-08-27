
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease
    {
        /// <summary>
        /// 
        /// </summary>
        CurrentDayNumber,
        /// <summary>
        /// 
        /// </summary>
        PhasedReleaseState,
        /// <summary>
        /// 
        /// </summary>
        StartDate,
        /// <summary>
        /// 
        /// </summary>
        TotalPauseDuration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.CurrentDayNumber => "currentDayNumber",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.PhasedReleaseState => "phasedReleaseState",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.StartDate => "startDate",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.TotalPauseDuration => "totalPauseDuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease? ToEnum(string value)
        {
            return value switch
            {
                "currentDayNumber" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.CurrentDayNumber,
                "phasedReleaseState" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.PhasedReleaseState,
                "startDate" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.StartDate,
                "totalPauseDuration" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.TotalPauseDuration,
                _ => null,
            };
        }
    }
}