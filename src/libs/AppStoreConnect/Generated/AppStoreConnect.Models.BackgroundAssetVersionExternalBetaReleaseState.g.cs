
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetVersionExternalBetaReleaseState
    {
        /// <summary>
        ///
        /// </summary>
        InReview,
        /// <summary>
        ///
        /// </summary>
        ProcessingForTesting,
        /// <summary>
        ///
        /// </summary>
        ReadyForBetaSubmission,
        /// <summary>
        ///
        /// </summary>
        ReadyForTesting,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        Superseded,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackgroundAssetVersionExternalBetaReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionExternalBetaReleaseState value)
        {
            return value switch
            {
                BackgroundAssetVersionExternalBetaReleaseState.InReview => "IN_REVIEW",
                BackgroundAssetVersionExternalBetaReleaseState.ProcessingForTesting => "PROCESSING_FOR_TESTING",
                BackgroundAssetVersionExternalBetaReleaseState.ReadyForBetaSubmission => "READY_FOR_BETA_SUBMISSION",
                BackgroundAssetVersionExternalBetaReleaseState.ReadyForTesting => "READY_FOR_TESTING",
                BackgroundAssetVersionExternalBetaReleaseState.Rejected => "REJECTED",
                BackgroundAssetVersionExternalBetaReleaseState.Superseded => "SUPERSEDED",
                BackgroundAssetVersionExternalBetaReleaseState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionExternalBetaReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "IN_REVIEW" => BackgroundAssetVersionExternalBetaReleaseState.InReview,
                "PROCESSING_FOR_TESTING" => BackgroundAssetVersionExternalBetaReleaseState.ProcessingForTesting,
                "READY_FOR_BETA_SUBMISSION" => BackgroundAssetVersionExternalBetaReleaseState.ReadyForBetaSubmission,
                "READY_FOR_TESTING" => BackgroundAssetVersionExternalBetaReleaseState.ReadyForTesting,
                "REJECTED" => BackgroundAssetVersionExternalBetaReleaseState.Rejected,
                "SUPERSEDED" => BackgroundAssetVersionExternalBetaReleaseState.Superseded,
                "WAITING_FOR_REVIEW" => BackgroundAssetVersionExternalBetaReleaseState.WaitingForReview,
                _ => null,
            };
        }
    }
}