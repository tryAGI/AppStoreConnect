
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBetaNotificationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BuildBetaNotifications,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBetaNotificationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBetaNotificationCreateRequestDataType value)
        {
            return value switch
            {
                BuildBetaNotificationCreateRequestDataType.BuildBetaNotifications => "buildBetaNotifications",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBetaNotificationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "buildBetaNotifications" => BuildBetaNotificationCreateRequestDataType.BuildBetaNotifications,
                _ => null,
            };
        }
    }
}