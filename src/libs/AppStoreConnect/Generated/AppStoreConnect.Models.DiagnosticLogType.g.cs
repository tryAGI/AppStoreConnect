
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DiagnosticLogType
    {
        /// <summary>
        /// 
        /// </summary>
        DiagnosticLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiagnosticLogTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiagnosticLogType value)
        {
            return value switch
            {
                DiagnosticLogType.DiagnosticLogs => "diagnosticLogs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiagnosticLogType? ToEnum(string value)
        {
            return value switch
            {
                "diagnosticLogs" => DiagnosticLogType.DiagnosticLogs,
                _ => null,
            };
        }
    }
}