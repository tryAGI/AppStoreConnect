
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterMatchmakingRuleAttributesType
    {
        /// <summary>
        /// 
        /// </summary>
        Compatible,
        /// <summary>
        /// 
        /// </summary>
        Distance,
        /// <summary>
        /// 
        /// </summary>
        Match,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterMatchmakingRuleAttributesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleAttributesType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleAttributesType.Compatible => "COMPATIBLE",
                GameCenterMatchmakingRuleAttributesType.Distance => "DISTANCE",
                GameCenterMatchmakingRuleAttributesType.Match => "MATCH",
                GameCenterMatchmakingRuleAttributesType.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleAttributesType? ToEnum(string value)
        {
            return value switch
            {
                "COMPATIBLE" => GameCenterMatchmakingRuleAttributesType.Compatible,
                "DISTANCE" => GameCenterMatchmakingRuleAttributesType.Distance,
                "MATCH" => GameCenterMatchmakingRuleAttributesType.Match,
                "TEAM" => GameCenterMatchmakingRuleAttributesType.Team,
                _ => null,
            };
        }
    }
}