
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterMatchmakingRuleCreateRequestDataAttributesType
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
    public static class GameCenterMatchmakingRuleCreateRequestDataAttributesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterMatchmakingRuleCreateRequestDataAttributesType value)
        {
            return value switch
            {
                GameCenterMatchmakingRuleCreateRequestDataAttributesType.Compatible => "COMPATIBLE",
                GameCenterMatchmakingRuleCreateRequestDataAttributesType.Distance => "DISTANCE",
                GameCenterMatchmakingRuleCreateRequestDataAttributesType.Match => "MATCH",
                GameCenterMatchmakingRuleCreateRequestDataAttributesType.Team => "TEAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterMatchmakingRuleCreateRequestDataAttributesType? ToEnum(string value)
        {
            return value switch
            {
                "COMPATIBLE" => GameCenterMatchmakingRuleCreateRequestDataAttributesType.Compatible,
                "DISTANCE" => GameCenterMatchmakingRuleCreateRequestDataAttributesType.Distance,
                "MATCH" => GameCenterMatchmakingRuleCreateRequestDataAttributesType.Match,
                "TEAM" => GameCenterMatchmakingRuleCreateRequestDataAttributesType.Team,
                _ => null,
            };
        }
    }
}