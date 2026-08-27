
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature
    {
        /// <summary>
        /// 
        /// </summary>
        DiagnosticType,
        /// <summary>
        /// 
        /// </summary>
        Insight,
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Signature,
        /// <summary>
        /// 
        /// </summary>
        Weight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignatureExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature value)
        {
            return value switch
            {
                BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.DiagnosticType => "diagnosticType",
                BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.Insight => "insight",
                BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.Logs => "logs",
                BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.Signature => "signature",
                BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.Weight => "weight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature? ToEnum(string value)
        {
            return value switch
            {
                "diagnosticType" => BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.DiagnosticType,
                "insight" => BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.Insight,
                "logs" => BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.Logs,
                "signature" => BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.Signature,
                "weight" => BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature.Weight,
                _ => null,
            };
        }
    }
}