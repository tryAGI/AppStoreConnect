
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalBetaState
    {
        /// <summary>
        ///
        /// </summary>
        BetaApproved,
        /// <summary>
        ///
        /// </summary>
        BetaRejected,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        InBetaReview,
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
        NotApplicable,
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
        ReadyForBetaSubmission,
        /// <summary>
        ///
        /// </summary>
        ReadyForBetaTesting,
        /// <summary>
        ///
        /// </summary>
        WaitingForBetaReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalBetaStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalBetaState value)
        {
            return value switch
            {
                ExternalBetaState.BetaApproved => "BETA_APPROVED",
                ExternalBetaState.BetaRejected => "BETA_REJECTED",
                ExternalBetaState.Expired => "EXPIRED",
                ExternalBetaState.InBetaReview => "IN_BETA_REVIEW",
                ExternalBetaState.InBetaTesting => "IN_BETA_TESTING",
                ExternalBetaState.InExportComplianceReview => "IN_EXPORT_COMPLIANCE_REVIEW",
                ExternalBetaState.MissingExportCompliance => "MISSING_EXPORT_COMPLIANCE",
                ExternalBetaState.NotApplicable => "NOT_APPLICABLE",
                ExternalBetaState.Processing => "PROCESSING",
                ExternalBetaState.ProcessingException => "PROCESSING_EXCEPTION",
                ExternalBetaState.ReadyForBetaSubmission => "READY_FOR_BETA_SUBMISSION",
                ExternalBetaState.ReadyForBetaTesting => "READY_FOR_BETA_TESTING",
                ExternalBetaState.WaitingForBetaReview => "WAITING_FOR_BETA_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalBetaState? ToEnum(string value)
        {
            return value switch
            {
                "BETA_APPROVED" => ExternalBetaState.BetaApproved,
                "BETA_REJECTED" => ExternalBetaState.BetaRejected,
                "EXPIRED" => ExternalBetaState.Expired,
                "IN_BETA_REVIEW" => ExternalBetaState.InBetaReview,
                "IN_BETA_TESTING" => ExternalBetaState.InBetaTesting,
                "IN_EXPORT_COMPLIANCE_REVIEW" => ExternalBetaState.InExportComplianceReview,
                "MISSING_EXPORT_COMPLIANCE" => ExternalBetaState.MissingExportCompliance,
                "NOT_APPLICABLE" => ExternalBetaState.NotApplicable,
                "PROCESSING" => ExternalBetaState.Processing,
                "PROCESSING_EXCEPTION" => ExternalBetaState.ProcessingException,
                "READY_FOR_BETA_SUBMISSION" => ExternalBetaState.ReadyForBetaSubmission,
                "READY_FOR_BETA_TESTING" => ExternalBetaState.ReadyForBetaTesting,
                "WAITING_FOR_BETA_REVIEW" => ExternalBetaState.WaitingForBetaReview,
                _ => null,
            };
        }
    }
}