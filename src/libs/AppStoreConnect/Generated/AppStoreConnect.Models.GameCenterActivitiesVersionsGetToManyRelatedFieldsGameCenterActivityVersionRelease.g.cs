
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease value)
        {
            return value switch
            {
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityVersionRelease.Version,
                _ => null,
            };
        }
    }
}