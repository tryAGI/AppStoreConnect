
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinusversionString,
        /// <summary>
        ///
        /// </summary>
        VersionString,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem.MinusversionString => "-versionString",
                GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem.VersionString => "versionString",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-versionString" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem.MinusversionString,
                "versionString" => GameCenterEnabledVersionsCompatibleVersionsGetToManyRelatedSortItem.VersionString,
                _ => null,
            };
        }
    }
}