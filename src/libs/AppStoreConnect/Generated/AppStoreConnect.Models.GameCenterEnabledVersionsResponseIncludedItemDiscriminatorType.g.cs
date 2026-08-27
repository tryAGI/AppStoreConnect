
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
        /// <summary>
        ///
        /// </summary>
        GameCenterEnabledVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterEnabledVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType.Apps => "apps",
                GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType.GameCenterEnabledVersions => "gameCenterEnabledVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType.Apps,
                "gameCenterEnabledVersions" => GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType.GameCenterEnabledVersions,
                _ => null,
            };
        }
    }
}