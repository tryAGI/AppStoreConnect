
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivitiesVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Activity,
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
    public static class GameCenterActivitiesVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterActivitiesVersionsGetToManyRelatedIncludeItem.Activity => "activity",
                GameCenterActivitiesVersionsGetToManyRelatedIncludeItem.DefaultImage => "defaultImage",
                GameCenterActivitiesVersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                GameCenterActivitiesVersionsGetToManyRelatedIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "activity" => GameCenterActivitiesVersionsGetToManyRelatedIncludeItem.Activity,
                "defaultImage" => GameCenterActivitiesVersionsGetToManyRelatedIncludeItem.DefaultImage,
                "localizations" => GameCenterActivitiesVersionsGetToManyRelatedIncludeItem.Localizations,
                "releases" => GameCenterActivitiesVersionsGetToManyRelatedIncludeItem.Releases,
                _ => null,
            };
        }
    }
}