
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum DiagnosticInsightDirection
    {
        /// <summary>
        ///
        /// </summary>
        Down,
        /// <summary>
        ///
        /// </summary>
        Undefined,
        /// <summary>
        ///
        /// </summary>
        Up,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiagnosticInsightDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiagnosticInsightDirection value)
        {
            return value switch
            {
                DiagnosticInsightDirection.Down => "DOWN",
                DiagnosticInsightDirection.Undefined => "UNDEFINED",
                DiagnosticInsightDirection.Up => "UP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiagnosticInsightDirection? ToEnum(string value)
        {
            return value switch
            {
                "DOWN" => DiagnosticInsightDirection.Down,
                "UNDEFINED" => DiagnosticInsightDirection.Undefined,
                "UP" => DiagnosticInsightDirection.Up,
                _ => null,
            };
        }
    }
}