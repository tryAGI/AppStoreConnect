
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionAttributesState
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Approved,
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
        ReadyForReview,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        ReplacedWithNewVersion,
        /// <summary>
        ///
        /// </summary>
        WaitingForReview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionAttributesState value)
        {
            return value switch
            {
                AppCustomProductPageVersionAttributesState.Accepted => "ACCEPTED",
                AppCustomProductPageVersionAttributesState.Approved => "APPROVED",
                AppCustomProductPageVersionAttributesState.InReview => "IN_REVIEW",
                AppCustomProductPageVersionAttributesState.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppCustomProductPageVersionAttributesState.ReadyForReview => "READY_FOR_REVIEW",
                AppCustomProductPageVersionAttributesState.Rejected => "REJECTED",
                AppCustomProductPageVersionAttributesState.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                AppCustomProductPageVersionAttributesState.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppCustomProductPageVersionAttributesState.Accepted,
                "APPROVED" => AppCustomProductPageVersionAttributesState.Approved,
                "IN_REVIEW" => AppCustomProductPageVersionAttributesState.InReview,
                "PREPARE_FOR_SUBMISSION" => AppCustomProductPageVersionAttributesState.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppCustomProductPageVersionAttributesState.ReadyForReview,
                "REJECTED" => AppCustomProductPageVersionAttributesState.Rejected,
                "REPLACED_WITH_NEW_VERSION" => AppCustomProductPageVersionAttributesState.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => AppCustomProductPageVersionAttributesState.WaitingForReview,
                _ => null,
            };
        }
    }
}