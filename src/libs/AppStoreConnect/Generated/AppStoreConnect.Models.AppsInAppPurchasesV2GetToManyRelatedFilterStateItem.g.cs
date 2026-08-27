
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFilterStateItem
    {
        /// <summary>
        /// 
        /// </summary>
        Approved,
        /// <summary>
        /// 
        /// </summary>
        DeveloperActionNeeded,
        /// <summary>
        /// 
        /// </summary>
        DeveloperRemovedFromSale,
        /// <summary>
        /// 
        /// </summary>
        InReview,
        /// <summary>
        /// 
        /// </summary>
        MissingMetadata,
        /// <summary>
        /// 
        /// </summary>
        PendingBinaryApproval,
        /// <summary>
        /// 
        /// </summary>
        ProcessingContent,
        /// <summary>
        /// 
        /// </summary>
        ReadyToSubmit,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        RemovedFromSale,
        /// <summary>
        /// 
        /// </summary>
        WaitingForReview,
        /// <summary>
        /// 
        /// </summary>
        WaitingForUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesV2GetToManyRelatedFilterStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFilterStateItem value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.Approved => "APPROVED",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.DeveloperActionNeeded => "DEVELOPER_ACTION_NEEDED",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.DeveloperRemovedFromSale => "DEVELOPER_REMOVED_FROM_SALE",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.InReview => "IN_REVIEW",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.MissingMetadata => "MISSING_METADATA",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.PendingBinaryApproval => "PENDING_BINARY_APPROVAL",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.ProcessingContent => "PROCESSING_CONTENT",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.ReadyToSubmit => "READY_TO_SUBMIT",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.Rejected => "REJECTED",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.RemovedFromSale => "REMOVED_FROM_SALE",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.WaitingForReview => "WAITING_FOR_REVIEW",
                AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.WaitingForUpload => "WAITING_FOR_UPLOAD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFilterStateItem? ToEnum(string value)
        {
            return value switch
            {
                "APPROVED" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.Approved,
                "DEVELOPER_ACTION_NEEDED" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.DeveloperActionNeeded,
                "DEVELOPER_REMOVED_FROM_SALE" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.DeveloperRemovedFromSale,
                "IN_REVIEW" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.InReview,
                "MISSING_METADATA" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.MissingMetadata,
                "PENDING_BINARY_APPROVAL" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.PendingBinaryApproval,
                "PROCESSING_CONTENT" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.ProcessingContent,
                "READY_TO_SUBMIT" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.ReadyToSubmit,
                "REJECTED" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.Rejected,
                "REMOVED_FROM_SALE" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.RemovedFromSale,
                "WAITING_FOR_REVIEW" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.WaitingForReview,
                "WAITING_FOR_UPLOAD" => AppsInAppPurchasesV2GetToManyRelatedFilterStateItem.WaitingForUpload,
                _ => null,
            };
        }
    }
}