
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.InReview => "IN_REVIEW",
                BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.ProcessingForTesting => "PROCESSING_FOR_TESTING",
                BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.ReadyForBetaSubmission => "READY_FOR_BETA_SUBMISSION",
                BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.ReadyForTesting => "READY_FOR_TESTING",
                BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.Rejected => "REJECTED",
                BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.Superseded => "SUPERSEDED",
                BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem? ToEnum(string value)
        {
            return value switch
            {
                "IN_REVIEW" => BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.InReview,
                "PROCESSING_FOR_TESTING" => BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.ProcessingForTesting,
                "READY_FOR_BETA_SUBMISSION" => BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.ReadyForBetaSubmission,
                "READY_FOR_TESTING" => BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.ReadyForTesting,
                "REJECTED" => BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.Rejected,
                "SUPERSEDED" => BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.Superseded,
                "WAITING_FOR_REVIEW" => BackgroundAssetsVersionsGetToManyRelatedFilterExternalBetaReleaseStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}