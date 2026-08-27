
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease
    {
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionReleaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease value)
        {
            return value switch
            {
                GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterDetailsActivityReleasesGetToManyRelatedFieldsGameCenterActivityVersionRelease.Version,
                _ => null,
            };
        }
    }
}