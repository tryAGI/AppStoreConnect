
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem
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
    public static class AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.Approved,
                "IN_REVIEW" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.Rejected,
                "REPLACED_WITH_NEW_VERSION" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}