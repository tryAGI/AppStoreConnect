
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem
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
    public static class BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem value)
        {
            return value switch
            {
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.Accepted => "ACCEPTED",
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.InReview => "IN_REVIEW",
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.ProcessingForDistribution => "PROCESSING_FOR_DISTRIBUTION",
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.ReadyForDistribution => "READY_FOR_DISTRIBUTION",
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.ReadyForReview => "READY_FOR_REVIEW",
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.Rejected => "REJECTED",
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.Superseded => "SUPERSEDED",
                BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.Accepted,
                "IN_REVIEW" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.PrepareForSubmission,
                "PROCESSING_FOR_DISTRIBUTION" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.ProcessingForDistribution,
                "READY_FOR_DISTRIBUTION" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.ReadyForDistribution,
                "READY_FOR_REVIEW" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.ReadyForReview,
                "REJECTED" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.Rejected,
                "SUPERSEDED" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.Superseded,
                "WAITING_FOR_REVIEW" => BackgroundAssetsVersionsGetToManyRelatedFilterAppStoreReleaseStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}