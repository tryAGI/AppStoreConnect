
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCrashLogsGetInstanceFieldsBetaCrashLog
    {
        /// <summary>
        ///
        /// </summary>
        LogText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCrashLogsGetInstanceFieldsBetaCrashLogExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCrashLogsGetInstanceFieldsBetaCrashLog value)
        {
            return value switch
            {
                BetaCrashLogsGetInstanceFieldsBetaCrashLog.LogText => "logText",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCrashLogsGetInstanceFieldsBetaCrashLog? ToEnum(string value)
        {
            return value switch
            {
                "logText" => BetaCrashLogsGetInstanceFieldsBetaCrashLog.LogText,
                _ => null,
            };
        }
    }
}