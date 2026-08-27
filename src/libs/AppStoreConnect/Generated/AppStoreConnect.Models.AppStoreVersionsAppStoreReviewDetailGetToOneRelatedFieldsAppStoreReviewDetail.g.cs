
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail
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
    public static class AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreReviewAttachments => "appStoreReviewAttachments",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.ContactEmail => "contactEmail",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.ContactFirstName => "contactFirstName",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.ContactLastName => "contactLastName",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.ContactPhone => "contactPhone",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountName => "demoAccountName",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountPassword => "demoAccountPassword",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountRequired => "demoAccountRequired",
                AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreReviewAttachments,
                "appStoreVersion" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.AppStoreVersion,
                "contactEmail" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.ContactEmail,
                "contactFirstName" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.ContactFirstName,
                "contactLastName" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.ContactLastName,
                "contactPhone" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.ContactPhone,
                "demoAccountName" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountName,
                "demoAccountPassword" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.DemoAccountRequired,
                "notes" => AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail.Notes,
                _ => null,
            };
        }
    }
}