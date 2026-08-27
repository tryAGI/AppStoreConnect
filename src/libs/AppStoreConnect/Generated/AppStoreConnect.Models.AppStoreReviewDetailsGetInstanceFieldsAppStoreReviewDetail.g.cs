
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail
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
    public static class AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail value)
        {
            return value switch
            {
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.AppStoreReviewAttachments => "appStoreReviewAttachments",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.AppStoreVersion => "appStoreVersion",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.ContactEmail => "contactEmail",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.ContactFirstName => "contactFirstName",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.ContactLastName => "contactLastName",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.ContactPhone => "contactPhone",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.DemoAccountName => "demoAccountName",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.DemoAccountPassword => "demoAccountPassword",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.DemoAccountRequired => "demoAccountRequired",
                AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.Notes => "notes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewAttachments" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.AppStoreReviewAttachments,
                "appStoreVersion" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.AppStoreVersion,
                "contactEmail" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.ContactEmail,
                "contactFirstName" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.ContactFirstName,
                "contactLastName" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.ContactLastName,
                "contactPhone" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.ContactPhone,
                "demoAccountName" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.DemoAccountName,
                "demoAccountPassword" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.DemoAccountPassword,
                "demoAccountRequired" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.DemoAccountRequired,
                "notes" => AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail.Notes,
                _ => null,
            };
        }
    }
}