
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease.Version,
                _ => null,
            };
        }
    }
}