
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewAttachments,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        ContactEmail,
        /// <summary>
        ///
        /// </summary>
        ContactFirstName,
        /// <summary>
        ///
        /// </summary>
        ContactLastName,
        /// <summary>
        ///
        /// </summary>
        ContactPhone,
        /// <summary>
        ///
        /// </summary>
        DemoAccountName,
        /// <summary>
        ///
        /// </summary>
        DemoAccountPassword,
        /// <summary>
        ///
        /// </summary>
        DemoAccountRequired,
        /// <summary>
        ///
        /// </summary>
        Notes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail value)
        {
            return value switch
            {
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.AppStoreReviewAttachments => "appStoreReviewAttachments",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.AppStoreVersion => "appStoreVersion",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.ContactEmail => "contactEmail",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.ContactFirstName => "contactFirstName",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.ContactLastName => "contactLastName",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.ContactPhone => "contactPhone",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.DemoAccountName => "demoAccountName",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.DemoAccountPassword => "demoAccountPassword",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.DemoAccountRequired => "demoAccountRequired",
                AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.AppStoreReviewAttachments,
                "appStoreVersion" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.AppStoreVersion,
                "contactEmail" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.ContactEmail,
                "contactFirstName" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.ContactFirstName,
                "contactLastName" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.ContactLastName,
                "contactPhone" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.ContactPhone,
                "demoAccountName" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.DemoAccountName,
                "demoAccountPassword" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.DemoAccountRequired,
                "notes" => AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail.Notes,
                _ => null,
            };
        }
    }
}