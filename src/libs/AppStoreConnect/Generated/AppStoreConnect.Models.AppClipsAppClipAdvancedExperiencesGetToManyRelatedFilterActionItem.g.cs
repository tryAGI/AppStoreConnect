
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem
    {
        /// <summary>
        ///
        /// </summary>
        Open,
        /// <summary>
        ///
        /// </summary>
        Play,
        /// <summary>
        ///
        /// </summary>
        View,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem value)
        {
            return value switch
            {
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem.Open => "OPEN",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem.Play => "PLAY",
                AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem.View => "VIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem? ToEnum(string value)
        {
            return value switch
            {
                "OPEN" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem.Open,
                "PLAY" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem.Play,
                "VIEW" => AppClipsAppClipAdvancedExperiencesGetToManyRelatedFilterActionItem.View,
                _ => null,
            };
        }
    }
}