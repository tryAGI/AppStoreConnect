
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DiagnosticSignatureAttributesDiagnosticType
    {
        /// <summary>
        /// 
        /// </summary>
        DiskWrites,
        /// <summary>
        /// 
        /// </summary>
        Hangs,
        /// <summary>
        /// 
        /// </summary>
        Launches,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiagnosticSignatureAttributesDiagnosticTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiagnosticSignatureAttributesDiagnosticType value)
        {
            return value switch
            {
                DiagnosticSignatureAttributesDiagnosticType.DiskWrites => "DISK_WRITES",
                DiagnosticSignatureAttributesDiagnosticType.Hangs => "HANGS",
                DiagnosticSignatureAttributesDiagnosticType.Launches => "LAUNCHES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiagnosticSignatureAttributesDiagnosticType? ToEnum(string value)
        {
            return value switch
            {
                "DISK_WRITES" => DiagnosticSignatureAttributesDiagnosticType.DiskWrites,
                "HANGS" => DiagnosticSignatureAttributesDiagnosticType.Hangs,
                "LAUNCHES" => DiagnosticSignatureAttributesDiagnosticType.Launches,
                _ => null,
            };
        }
    }
}