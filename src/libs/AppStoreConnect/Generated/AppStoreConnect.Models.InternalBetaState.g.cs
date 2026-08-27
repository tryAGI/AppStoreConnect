
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InternalBetaState
    {
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        InBetaTesting,
        /// <summary>
        /// 
        /// </summary>
        InExportComplianceReview,
        /// <summary>
        /// 
        /// </summary>
        MissingExportCompliance,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        ProcessingException,
        /// <summary>
        /// 
        /// </summary>
        ReadyForBetaTesting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternalBetaStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalBetaState value)
        {
            return value switch
            {
                InternalBetaState.Expired => "EXPIRED",
                InternalBetaState.InBetaTesting => "IN_BETA_TESTING",
                InternalBetaState.InExportComplianceReview => "IN_EXPORT_COMPLIANCE_REVIEW",
                InternalBetaState.MissingExportCompliance => "MISSING_EXPORT_COMPLIANCE",
                InternalBetaState.Processing => "PROCESSING",
                InternalBetaState.ProcessingException => "PROCESSING_EXCEPTION",
                InternalBetaState.ReadyForBetaTesting => "READY_FOR_BETA_TESTING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalBetaState? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED" => InternalBetaState.Expired,
                "IN_BETA_TESTING" => InternalBetaState.InBetaTesting,
                "IN_EXPORT_COMPLIANCE_REVIEW" => InternalBetaState.InExportComplianceReview,
                "MISSING_EXPORT_COMPLIANCE" => InternalBetaState.MissingExportCompliance,
                "PROCESSING" => InternalBetaState.Processing,
                "PROCESSING_EXCEPTION" => InternalBetaState.ProcessingException,
                "READY_FOR_BETA_TESTING" => InternalBetaState.ReadyForBetaTesting,
                _ => null,
            };
        }
    }
}