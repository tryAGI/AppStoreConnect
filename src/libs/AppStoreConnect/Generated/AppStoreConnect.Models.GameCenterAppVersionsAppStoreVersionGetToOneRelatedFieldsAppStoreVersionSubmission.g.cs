
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission.AppStoreVersion => "appStoreVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionSubmission.AppStoreVersion,
                _ => null,
            };
        }
    }
}