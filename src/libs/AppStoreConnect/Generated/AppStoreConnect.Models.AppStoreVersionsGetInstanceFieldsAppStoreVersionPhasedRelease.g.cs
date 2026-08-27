
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease
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
    public static class AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease.CurrentDayNumber => "currentDayNumber",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease.PhasedReleaseState => "phasedReleaseState",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease.StartDate => "startDate",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease.TotalPauseDuration => "totalPauseDuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease? ToEnum(string value)
        {
            return value switch
            {
                "currentDayNumber" => AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease.CurrentDayNumber,
                "phasedReleaseState" => AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease.PhasedReleaseState,
                "startDate" => AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease.StartDate,
                "totalPauseDuration" => AppStoreVersionsGetInstanceFieldsAppStoreVersionPhasedRelease.TotalPauseDuration,
                _ => null,
            };
        }
    }
}