
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DiagnosticInsightType
    {
        /// <summary>
        /// 
        /// </summary>
        Trend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiagnosticInsightTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiagnosticInsightType value)
        {
            return value switch
            {
                DiagnosticInsightType.Trend => "TREND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiagnosticInsightType? ToEnum(string value)
        {
            return value switch
            {
                "TREND" => DiagnosticInsightType.Trend,
                _ => null,
            };
        }
    }
}