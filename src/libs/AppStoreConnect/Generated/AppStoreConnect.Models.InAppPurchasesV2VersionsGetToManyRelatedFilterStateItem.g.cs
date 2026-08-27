
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem
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
        DeveloperRejected,
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
    public static class InAppPurchasesV2VersionsGetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.Accepted => "ACCEPTED",
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.Approved => "APPROVED",
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.DeveloperRejected => "DEVELOPER_REJECTED",
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.PrepareForSubmission => "PREPARE_FOR_SUBMISSION",
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.ReadyForReview => "READY_FOR_REVIEW",
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.ReplacedWithNewVersion => "REPLACED_WITH_NEW_VERSION",
                InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.Accepted,
                "APPROVED" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.Approved,
                "DEVELOPER_REJECTED" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.DeveloperRejected,
                "IN_REVIEW" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.InReview,
                "PREPARE_FOR_SUBMISSION" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.PrepareForSubmission,
                "READY_FOR_REVIEW" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.ReadyForReview,
                "REJECTED" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.Rejected,
                "REPLACED_WITH_NEW_VERSION" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.ReplacedWithNewVersion,
                "WAITING_FOR_REVIEW" => InAppPurchasesV2VersionsGetToManyRelatedFilterStateItem.WaitingForReview,
                _ => null,
            };
        }
    }
}