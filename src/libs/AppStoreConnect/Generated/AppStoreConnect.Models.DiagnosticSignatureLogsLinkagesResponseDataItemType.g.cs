
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum DiagnosticSignatureLogsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        DiagnosticLogs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiagnosticSignatureLogsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiagnosticSignatureLogsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                DiagnosticSignatureLogsLinkagesResponseDataItemType.DiagnosticLogs => "diagnosticLogs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiagnosticSignatureLogsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "diagnosticLogs" => DiagnosticSignatureLogsLinkagesResponseDataItemType.DiagnosticLogs,
                _ => null,
            };
        }
    }
}