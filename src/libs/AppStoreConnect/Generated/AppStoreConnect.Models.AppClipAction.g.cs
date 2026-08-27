
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAction
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
    public static class AppClipActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAction value)
        {
            return value switch
            {
                AppClipAction.Open => "OPEN",
                AppClipAction.Play => "PLAY",
                AppClipAction.View => "VIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAction? ToEnum(string value)
        {
            return value switch
            {
                "OPEN" => AppClipAction.Open,
                "PLAY" => AppClipAction.Play,
                "VIEW" => AppClipAction.View,
                _ => null,
            };
        }
    }
}