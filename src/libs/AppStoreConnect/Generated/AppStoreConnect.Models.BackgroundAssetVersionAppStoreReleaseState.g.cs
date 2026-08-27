
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetVersionAppStoreReleaseState
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        PrepareForSubmission,
        /// <summary>
        /// 
        /// </summary>
        ProcessingForDistribution,
        /// <summary>
        /// 
        /// </summary>
        ReadyForDistribution,
        /// <summary>
        /// 
        /// </summary>
        ReadyForReview,
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
    public static class BackgroundAssetVersionAppStoreReleaseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetVersionAppStoreReleaseState value)
        {
            return value switch
            {
                BackgroundAssetVersionAppStoreReleaseState.Accepted => "ACCEPTED",
                BackgroundAssetVersionAppStoreReleaseState.InReview => "IN_REVIEW",
                BackgroundAssetVersionAppStoreReleaseState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                BackgroundAssetVersionAppStoreReleaseState.ProcessingForDistribution => "PROCESSING_FOR_DISTRIBUTION",
                BackgroundAssetVersionAppStoreReleaseState.ReadyForDistribution => "READY_FOR_DISTRIBUTION",
                BackgroundAssetVersionAppStoreReleaseState.ReadyForReview => "READY_FOR_REVIEW",
                BackgroundAssetVersionAppStoreReleaseState.Rejected => "REJECTED",
                BackgroundAssetVersionAppStoreReleaseState.Superseded => "SUPERSEDED",
                BackgroundAssetVersionAppStoreReleaseState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetVersionAppStoreReleaseState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => BackgroundAssetVersionAppStoreReleaseState.Accepted,
                "IN_REVIEW" => BackgroundAssetVersionAppStoreReleaseState.InReview,
                "PREPARE_FOR_SUBMISSION" => BackgroundAssetVersionAppStoreReleaseState.PrepareForSubmission,
                "PROCESSING_FOR_DISTRIBUTION" => BackgroundAssetVersionAppStoreReleaseState.ProcessingForDistribution,
                "READY_FOR_DISTRIBUTION" => BackgroundAssetVersionAppStoreReleaseState.ReadyForDistribution,
                "READY_FOR_REVIEW" => BackgroundAssetVersionAppStoreReleaseState.ReadyForReview,
                "REJECTED" => BackgroundAssetVersionAppStoreReleaseState.Rejected,
                "SUPERSEDED" => BackgroundAssetVersionAppStoreReleaseState.Superseded,
                "WAITING_FOR_REVIEW" => BackgroundAssetVersionAppStoreReleaseState.WaitingForReview,
                _ => null,
            };
        }
    }
}