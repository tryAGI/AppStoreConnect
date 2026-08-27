
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCrashLogType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaCrashLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCrashLogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCrashLogType value)
        {
            return value switch
            {
                BetaCrashLogType.BetaCrashLogs => "betaCrashLogs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCrashLogType? ToEnum(string value)
        {
            return value switch
            {
                "betaCrashLogs" => BetaCrashLogType.BetaCrashLogs,
                _ => null,
            };
        }
    }
}