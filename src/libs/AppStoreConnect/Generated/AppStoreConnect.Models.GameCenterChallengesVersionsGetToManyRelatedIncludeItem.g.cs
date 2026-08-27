
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengesVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Challenge,
        /// <summary>
        /// 
        /// </summary>
        DefaultImage,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        Releases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengesVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterChallengesVersionsGetToManyRelatedIncludeItem.Challenge => "challenge",
                GameCenterChallengesVersionsGetToManyRelatedIncludeItem.DefaultImage => "defaultImage",
                GameCenterChallengesVersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                GameCenterChallengesVersionsGetToManyRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterChallengesVersionsGetToManyRelatedIncludeItem.Challenge,
                "defaultImage" => GameCenterChallengesVersionsGetToManyRelatedIncludeItem.DefaultImage,
                "localizations" => GameCenterChallengesVersionsGetToManyRelatedIncludeItem.Localizations,
                "releases" => GameCenterChallengesVersionsGetToManyRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}