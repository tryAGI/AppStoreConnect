
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaNotificationType
    {
        /// <summary>
        ///
        /// </summary>
        BuildBetaNotifications,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaNotificationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaNotificationType value)
        {
            return value switch
            {
                BuildBetaNotificationType.BuildBetaNotifications => "buildBetaNotifications",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaNotificationType? ToEnum(string value)
        {
            return value switch
            {
                "buildBetaNotifications" => BuildBetaNotificationType.BuildBetaNotifications,
                _ => null,
            };
        }
    }
}