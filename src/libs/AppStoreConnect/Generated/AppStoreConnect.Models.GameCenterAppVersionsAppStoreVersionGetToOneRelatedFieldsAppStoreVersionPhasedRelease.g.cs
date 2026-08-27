
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.CurrentDayNumber => "currentDayNumber",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.PhasedReleaseState => "phasedReleaseState",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.StartDate => "startDate",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.TotalPauseDuration => "totalPauseDuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease? ToEnum(string value)
        {
            return value switch
            {
                "currentDayNumber" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.CurrentDayNumber,
                "phasedReleaseState" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.PhasedReleaseState,
                "startDate" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.StartDate,
                "totalPauseDuration" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionPhasedRelease.TotalPauseDuration,
                _ => null,
            };
        }
    }
}