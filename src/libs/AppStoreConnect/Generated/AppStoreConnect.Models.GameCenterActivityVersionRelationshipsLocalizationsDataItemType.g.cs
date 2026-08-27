
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivityLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityVersionRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                GameCenterActivityVersionRelationshipsLocalizationsDataItemType.GameCenterActivityLocalizations => "gameCenterActivityLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityLocalizations" => GameCenterActivityVersionRelationshipsLocalizationsDataItemType.GameCenterActivityLocalizations,
                _ => null,
            };
        }
    }
}