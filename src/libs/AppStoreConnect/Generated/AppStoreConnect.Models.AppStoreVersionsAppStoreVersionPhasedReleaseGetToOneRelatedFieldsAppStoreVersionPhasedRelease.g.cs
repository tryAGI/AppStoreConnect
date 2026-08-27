
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease
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
    public static class AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease.CurrentDayNumber => "currentDayNumber",
                AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease.PhasedReleaseState => "phasedReleaseState",
                AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease.StartDate => "startDate",
                AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease.TotalPauseDuration => "totalPauseDuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease? ToEnum(string value)
        {
            return value switch
            {
                "currentDayNumber" => AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease.CurrentDayNumber,
                "phasedReleaseState" => AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease.PhasedReleaseState,
                "startDate" => AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease.StartDate,
                "totalPauseDuration" => AppStoreVersionsAppStoreVersionPhasedReleaseGetToOneRelatedFieldsAppStoreVersionPhasedRelease.TotalPauseDuration,
                _ => null,
            };
        }
    }
}