
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail
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
    public static class AppStoreVersionsGetInstanceFieldsAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.AppStoreReviewAttachments => "appStoreReviewAttachments",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.ContactEmail => "contactEmail",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.ContactFirstName => "contactFirstName",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.ContactLastName => "contactLastName",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.ContactPhone => "contactPhone",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.DemoAccountName => "demoAccountName",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.DemoAccountPassword => "demoAccountPassword",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.DemoAccountRequired => "demoAccountRequired",
                AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.AppStoreReviewAttachments,
                "appStoreVersion" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.AppStoreVersion,
                "contactEmail" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.ContactEmail,
                "contactFirstName" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.ContactFirstName,
                "contactLastName" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.ContactLastName,
                "contactPhone" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.ContactPhone,
                "demoAccountName" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.DemoAccountName,
                "demoAccountPassword" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.DemoAccountRequired,
                "notes" => AppStoreVersionsGetInstanceFieldsAppStoreReviewDetail.Notes,
                _ => null,
            };
        }
    }
}