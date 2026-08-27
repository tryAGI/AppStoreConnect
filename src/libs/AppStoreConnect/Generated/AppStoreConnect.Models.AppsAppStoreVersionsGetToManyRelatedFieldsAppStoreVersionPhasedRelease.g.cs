
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease
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
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease.CurrentDayNumber => "currentDayNumber",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease.PhasedReleaseState => "phasedReleaseState",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease.StartDate => "startDate",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease.TotalPauseDuration => "totalPauseDuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease? ToEnum(string value)
        {
            return value switch
            {
                "currentDayNumber" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease.CurrentDayNumber,
                "phasedReleaseState" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease.PhasedReleaseState,
                "startDate" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease.StartDate,
                "totalPauseDuration" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionPhasedRelease.TotalPauseDuration,
                _ => null,
            };
        }
    }
}