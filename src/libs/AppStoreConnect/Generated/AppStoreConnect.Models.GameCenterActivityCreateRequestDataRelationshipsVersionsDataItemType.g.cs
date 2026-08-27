
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType value)
        {
            return value switch
            {
                GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType.GameCenterActivityVersions => "gameCenterActivityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersions" => GameCenterActivityCreateRequestDataRelationshipsVersionsDataItemType.GameCenterActivityVersions,
                _ => null,
            };
        }
    }
}