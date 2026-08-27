
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum DiagnosticSignatureType
    {
        /// <summary>
        ///
        /// </summary>
        DiagnosticSignatures,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiagnosticSignatureTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiagnosticSignatureType value)
        {
            return value switch
            {
                DiagnosticSignatureType.DiagnosticSignatures => "diagnosticSignatures",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiagnosticSignatureType? ToEnum(string value)
        {
            return value switch
            {
                "diagnosticSignatures" => DiagnosticSignatureType.DiagnosticSignatures,
                _ => null,
            };
        }
    }
}