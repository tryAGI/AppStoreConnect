
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam
    {
        /// <summary>
        /// 
        /// </summary>
        MaxPlayers,
        /// <summary>
        /// 
        /// </summary>
        MinPlayers,
        /// <summary>
        /// 
        /// </summary>
        ReferenceName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeamExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam.MaxPlayers => "maxPlayers",
                GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam.MinPlayers => "minPlayers",
                GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam.ReferenceName => "referenceName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam? ToEnum(string value)
        {
            return value switch
            {
                "maxPlayers" => GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam.MaxPlayers,
                "minPlayers" => GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam.MinPlayers,
                "referenceName" => GameCenterMatchmakingRuleSetsTeamsGetToManyRelatedFieldsGameCenterMatchmakingTeam.ReferenceName,
                _ => null,
            };
        }
    }
}